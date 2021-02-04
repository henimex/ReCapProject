using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("{0} Added", car.BrandId);

            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            Console.WriteLine("{0} Updated", car.BrandId);
        }

        public void Delete(Car car)
        {
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
            return _carDal.GetAll(P => P.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(P => P.ColorId == colorId).ToList();
        }
    }
}
