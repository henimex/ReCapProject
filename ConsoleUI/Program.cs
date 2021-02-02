using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            ListAllCars(carManager);

            foreach (var color in carManager.GetAllByColorId(1))
            {
                Console.WriteLine("Cars by Color ID = 1");
                Console.WriteLine(color.Brand);
            }

            carManager.Add(new Car { Brand = "Ferrari", ColorId = 1 });

            foreach (var carModel in carManager.GetAllByModelYear("2016"))
            {
                Console.WriteLine("Cars by Model Year 2016 = {0} {1}", carModel.Brand, carModel.Description);
            }

            Car carToDelete = new Car { CarId = 10, Brand = "Aston Martin", ColorId = 6, Description = "Available", DailyPrice = 256, ModelYear = "2001" };
            carManager.Delete(carToDelete);

            Car carToUpdate = new Car { CarId = 6, Brand = "Fiat", ColorId = 3, DailyPrice = 350, Description = "Albea", ModelYear = "2002" };
            carManager.Update(carToUpdate);

            ListAllCars(carManager);
        }

        private static void ListAllCars(CarManager carManager)
        {
            Console.WriteLine("Cars:");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Brand);
            }
        }
    }
}
