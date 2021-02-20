using System;
using System.Collections.Generic;
using System.Linq;
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
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.ItemsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId), Messages.SingleResult);
        }

        public IDataResult<List<CarRentsDto>> GetDetailedRentals()
        {
            return new SuccessDataResult<List<CarRentsDto>>(_rentalDal.GetRentalDetails(), Messages.ItemsListed);
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
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
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
    }
}
