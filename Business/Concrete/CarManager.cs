using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAllByPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("{0} Added", car.BrandId);
            }
            else
            {
                Console.WriteLine("Daily prica must be greater than Zero (0)");
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("{0} Updated", car.BrandId);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("{0} Deleted", car.BrandId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByModelYear(string modelYear)
        {
            return _carDal.GetAll(p => p.ModelYear == modelYear).ToList();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId).ToList();
        }
    }
}
