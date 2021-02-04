using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{ Id = 1, BrandId = 1 , ColorId = 1, DailyPrice = 560, Description = "Polo Hatch Back", ModelYear = "2020"},
                new Car{ Id = 2, BrandId = 2 , ColorId = 3, DailyPrice = 160, Description = "Astra Sedan", ModelYear = "2019"},
                new Car{ Id = 3, BrandId = 3 , ColorId = 3, DailyPrice = 410, Description = "206 Coupe", ModelYear = "2016"},
                new Car{ Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 758, Description = "Fiesta Sedan", ModelYear = "2016"},
                new Car{ Id = 5, BrandId = 4 , ColorId = 2, DailyPrice = 1530, Description = "Transit", ModelYear = "2000"},
                new Car{ Id = 6, BrandId = 5 , ColorId = 3, DailyPrice = 650, Description = "Albea", ModelYear = "2002"},
                new Car{ Id = 7, BrandId = 5 , ColorId = 1, DailyPrice = 590, Description = "Clio", ModelYear = "2019"},
                new Car{ Id = 8, BrandId = 6 , ColorId = 4, DailyPrice = 440, Description = "Qashqai", ModelYear = "2020"}
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return null;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
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
