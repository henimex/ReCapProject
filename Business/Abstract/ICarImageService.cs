using Core.Utilities.Result;
using Entites.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();

        IDataResult<List<CarImage>> GetImagesByCarId(int carId);

        IDataResult<CarImage> GetById(int imageId);

        IResult Add(CarImage carImage);

        IResult Update(CarImage carImage);

        IResult Delete(CarImage carImage);
    }
}