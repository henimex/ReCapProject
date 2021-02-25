using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessRules.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;

namespace Business.BusinessRules.Concrete
{
    public class CarImageRules : ICarImageRules
    {
        private ICarImageDal _carImageDal;
        private ICarDal _carDal;

        public CarImageRules(ICarImageDal carImageDal, ICarDal carDal)
        {
            _carImageDal = carImageDal;
            _carDal = carDal;
        }

        public IResult MaxImagePerCar(int carId, int imageLimit)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (result >= imageLimit) return new ErrorResult(Messages.ImageLimitPerCar);
            return new SuccessResult();
        }
    }
}
