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

            Console.WriteLine("Cars:");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Brand);
            }

            foreach (var color in carManager.GetAllByColorId(1))
            {
                Console.WriteLine("Cars by Color ID = 1");
                Console.WriteLine(color.Brand);
            }

            carManager.Add(new Car{Brand = "Ferrari", ColorId = 1});
        }
    }
}
