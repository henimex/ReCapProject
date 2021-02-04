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
            //RefactoredMethod();

        }

        private static void RefactoredMethod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            ListAllCars(carManager);

            foreach (var color in carManager.GetAllByColorId(1))
            {
                Console.WriteLine("Cars by Color ID = 1");
                Console.WriteLine(color.BrandId);
            }

            carManager.Add(new Car {BrandId = 3, ColorId = 1});

            foreach (var carModel in carManager.GetAllByModelYear("2016"))
            {
                Console.WriteLine("Cars by Model Year 2016 = {0} {1}", carModel.BrandId, carModel.Description);
            }

            Car carToDelete = new Car
                {Id = 10, BrandId = 1, ColorId = 6, Description = "Available", DailyPrice = 256, ModelYear = "2001"};
            carManager.Delete(carToDelete);

            Car carToUpdate = new Car
                {Id = 6, BrandId = 2, ColorId = 3, DailyPrice = 350, Description = "Albea", ModelYear = "2002"};
            carManager.Update(carToUpdate);

            ListAllCars(carManager);
        }

        private static void ListAllCars(CarManager carManager)
        {
            Console.WriteLine("Cars:");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
