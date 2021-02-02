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
        
        public List<Car> GetAllByModelYear(string modelYear)
        {
            return _carDal.GetAllByModelYear(modelYear).ToList();
        }

        public void Add(Car car)
        {
            Console.WriteLine("{0} Added",car.Brand);

            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            Console.WriteLine("{0} Updated", car.Brand);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("{0} Deleted", car.Brand);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAllByColorId(colorId).ToList();
        }
    }
}
