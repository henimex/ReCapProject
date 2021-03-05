using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessRules.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.BusinessTools;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;
        private ICarImageRules _carImageRules;

        public CarImageManager(ICarImageDal carImageDal, ICarImageRules carImageRules)
        {
            _carImageDal = carImageDal;
            _carImageRules = carImageRules;
        }

        [PerformanceAspect(5)]
        [CacheAspect()]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.CarId == carId));
        }

        public IDataResult<CarImage> GetById(int imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.Id == imageId));
        }

        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRuleTool.Run(
                _carImageRules.MaxImagePerCar(carImage.CarId, OptionVariables.MaxImagePerCar)
            );

            if (result != null) return result;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }

        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }
    }
}
