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
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndBrand(int colorId, int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCar(int id);
        IDataResult<Car> GetById(int carId);
        IResult AddTransactional(Car car);
        //List<CarDetailDto> GetCarDetails(string carName);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        
    }
}
