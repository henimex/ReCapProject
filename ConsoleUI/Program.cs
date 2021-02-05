using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            colorManager.Add(new Color { ColorName = "White" });
            colorManager.Add(new Color { ColorName = "Silver" });
            colorManager.Add(new Color { ColorName = "Blue" });
            
            brandManager.Add(new Brand{BrandName = "Volkswagen" });
            brandManager.Add(new Brand{BrandName = "Toyota" });
            brandManager.Add(new Brand{BrandName = "Renault" });
            brandManager.Add(new Brand{BrandName = "T" });
            brandManager.Add(new Brand{BrandName = "Fiat" });
            brandManager.Add(new Brand{BrandName = "Opel" });
            
            carManager.Add(new Car{BrandId = 1,ColorId = 1,DailyPrice = 250,Description = "Available", ModelYear = "2000"});
            carManager.Add(new Car{BrandId = 5,ColorId = 3,DailyPrice = 1000,Description = "Not Available", ModelYear = "2005"});
            carManager.Add(new Car{BrandId = 2,ColorId = 1,DailyPrice = 500,Description = "On Service", ModelYear = "2010"});
            carManager.Add(new Car{BrandId = 2,ColorId = 1,DailyPrice = 500,Description = "On Service", ModelYear = "2010"});
            carManager.Add(new Car{BrandId = 3,ColorId = 3,DailyPrice = 500,Description = "Available", ModelYear = "2017"});
            carManager.Add(new Car{BrandId = 4,ColorId = 5,DailyPrice = 750,Description = "Available", ModelYear = "2019"});
            */

            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());

            brandManager.Add(new Brand { BrandName = "T" });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 0, Description = "Available", ModelYear = "2000" });

            AllCars(carManager, brandManager, colorManager);

            AllCarsByPrice(carManager, brandManager, colorManager);

            AllCarsByRed(carManager, brandManager, colorManager);

            AllCarsByBrand(carManager, brandManager, colorManager);
        }

        private static void AllCarsByBrand(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: Henimex Rent A Car ::. \n\t\t\t\t\tCar List Filter : Brand[Toyota]\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByBrandId(2))
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Description);
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCarsByRed(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: Henimex Rent A Car ::. \n\t\t\t\t\tCar List Filter : Color[RED]\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Description);
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");

            
        }

        private static void AllCarsByPrice(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: Henimex Rent A Car ::. \n\t\t\t\t\tCar List Filter : Price [500,800]\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByPrice(500, 800))
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Description);
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCars(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: Henimex Rent A Car ::. \n\t\t\t\t\tCar List Filter : No Filter Selected\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Description);
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");
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

            carManager.Add(new Car { BrandId = 3, ColorId = 1 });

            foreach (var carModel in carManager.GetAllByModelYear("2016"))
            {
                Console.WriteLine("Cars by Model Year 2016 = {0} {1}", carModel.BrandId, carModel.Description);
            }

            Car carToDelete = new Car
            { Id = 10, BrandId = 1, ColorId = 6, Description = "Available", DailyPrice = 256, ModelYear = "2001" };
            carManager.Delete(carToDelete);

            Car carToUpdate = new Car
            { Id = 6, BrandId = 2, ColorId = 3, DailyPrice = 350, Description = "Albea", ModelYear = "2002" };
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
