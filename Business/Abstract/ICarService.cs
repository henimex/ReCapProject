using System.Collections.Generic;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByModelYear(string modelYear);
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
        //List<CarDetailDto> GetCarDetails(string carName);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
