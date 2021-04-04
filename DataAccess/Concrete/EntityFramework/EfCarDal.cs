using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<HenRentACarContext, Car>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (HenRentACarContext context = new HenRentACarContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join cl in context.Colors on c.ColorId equals cl.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 CarId = c.Id,
                                 BrandId = b.Id,
                                 BrandName = b.BrandName,
                                 ColorId = cl.Id,
                                 ColorName = cl.ColorName,
                                 Point = c.Point,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
