using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;

namespace Business.BusinessRules.Abstract
{
    public interface ICarImageRules
    {
        IResult MaxImagePerCar(int carId, int imageLimit);
    }
}
