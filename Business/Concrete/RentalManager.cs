using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.ItemsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId), Messages.SingleResult);
        }

        public IDataResult<List<CarRentsDto>> GetDetailedRentals()
        {
            return new SuccessDataResult<List<CarRentsDto>>(_rentalDal.GetRentalDetails(), Messages.ItemsListed);
        }

        public IDataResult<List<CarRentsDto>> GetDetailedRentalsByCarId(int carId)
        {
            if (_rentalDal.GetRentalDetails(r => r.CarId == carId).Count > 0)
            {
                return new SuccessDataResult<List<CarRentsDto>>(_rentalDal.GetRentalDetails(r => r.CarId == carId), Messages.ItemsListed);
            }

            return new ErrorDataResult<List<CarRentsDto>>(Messages.ListIsNull);
        }

        public IResult GetCarStatus(int carId)
        {
            if (_rentalDal.GetRentalDetails(r => r.CarId == carId && r.ReturnDate == null).Count > 0)
            {
                return new SuccessResult(Messages.CarInRent);
            }

            return new ErrorResult(Messages.AvailableForRent);
        }

        public IResult RentedCarReturned(int carId)
        {
            var result = _rentalDal.GetAll(r => r.CarId == carId);
            var returnDate = result.LastOrDefault();
            if (returnDate.ReturnDate == null)
            {
                returnDate.ReturnDate = DateTime.Now;
                _rentalDal.Update(returnDate);
                return new SuccessResult(Messages.CarDelivered);
            }

            return new ErrorResult(Messages.CarReturnError);
        }

        public IResult Add(Rental rental)
        {
            if (CheckRentStatus(rental).Success)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(CheckRentStatus(rental).Message);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult CheckRentStatus(Rental rental)
        {
            //postmanden gonderildiginde tarih dogru geliyor fakat angularda arasını aldıgı icin secili gunleri dahil etmeden gonderiyor.
            //o yuzden gelen tarihlere 1 gün ekleyerek sorgulama calısıtıroyrum
            //tarih aralıgı olayını angulardan düzelttikten sonra bu ekleme islemini kaldıracagım.
            var result = _rentalDal.GetAll();
            var dayAddedRentDate = rental.RentDate.AddDays(1);
            var dayAddedReturnDate = rental.ReturnDate.AddDays(1);
            if (result.Any(x => x.CarId == rental.CarId && x.ReturnDate.Ticks >= dayAddedRentDate.Ticks && x.RentDate.Ticks <= dayAddedReturnDate.Ticks))
            {
                return new ErrorResult(Messages.NotAvailableForRent);
            }
            return new SuccessResult(Messages.AvailableForRent);
        }

        public List<string> GetDisabledDays(int carId)
        {
            var disabledDates = new List<string>();
            var result = _rentalDal.GetAll().Where(x=>x.CarId == carId).Select(x=> new {x.RentDate, x.ReturnDate}).ToList();
            var startDate = result.Select(x => x.RentDate).ToList();
            var endDate = result.Select(x => x.ReturnDate).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                //for (var disDate = startResult[i]; disDate <= endResult[i]; disDate = disDate.AddDays(1))
                for (var disDate = startDate[i]; disDate <= endDate[i]; disDate = disDate.AddDays(1))
                {
                    disabledDates.Add(disDate.ToString("yyyy-MM-dd"));
                }
            }

            return disabledDates;
        }
    }
}
