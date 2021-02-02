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
                new Car{ CarId = 1, Brand = "Wolksvagen" , ColorId = 1, DailyPrice = 560, Description = "Polo Hatch Back", ModelYear = "2020"},
                new Car{ CarId = 2, Brand = "Opel" , ColorId = 3, DailyPrice = 160, Description = "Astra Sedan", ModelYear = "2019"},
                new Car{ CarId = 3, Brand = "Peugeot" , ColorId = 3, DailyPrice = 410, Description = "206 Coupe", ModelYear = "2016"},
                new Car{ CarId = 4, Brand = "Ford" , ColorId = 4, DailyPrice = 758, Description = "Fiesta Sedan", ModelYear = "2016"},
                new Car{ CarId = 5, Brand = "Ford" , ColorId = 2, DailyPrice = 1530, Description = "Transit", ModelYear = "2000"},
                new Car{ CarId = 6, Brand = "Fiat" , ColorId = 3, DailyPrice = 650, Description = "Albea", ModelYear = "2002"},
                new Car{ CarId = 7, Brand = "Renault" , ColorId = 1, DailyPrice = 590, Description = "Clio", ModelYear = "2019"},
                new Car{ CarId = 8, Brand = "Nissan" , ColorId = 4, DailyPrice = 440, Description = "Qashqai", ModelYear = "2020"}
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
