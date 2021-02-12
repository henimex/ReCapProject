using System.Collections.Generic;
using Core.Utilities.Result;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllByModelYear(string modelYear);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
        //List<CarDetailDto> GetCarDetails(string carName);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
