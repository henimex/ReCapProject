using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
