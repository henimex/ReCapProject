using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId = 1, Brand = "Wolksvagen" , ColorId = 1, DailyPrice = 56000, Description = "Polo Hatch Back", ModelYear = "2020"},
                new Car{ CarId = 1, Brand = "Opel" , ColorId = 3, DailyPrice = 160000, Description = "Astra Sedan", ModelYear = "2019"},
                new Car{ CarId = 1, Brand = "Peugeot" , ColorId = 3, DailyPrice = 4100, Description = "206 Coupe", ModelYear = "2005"},
                new Car{ CarId = 1, Brand = "Ford" , ColorId = 4, DailyPrice = 75800, Description = "Fiesta Sedan", ModelYear = "2016"},
                new Car{ CarId = 1, Brand = "BMW" , ColorId = 2, DailyPrice = 153000, Description = "X5- 4x4", ModelYear = "2021"},
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.Brand = car.Brand;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public List<Car> GetAllByModelYear(string modelYear)
        {
            return _cars.Where(p => p.ModelYear == modelYear).ToList();
        }
    }
}
