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
        public List<CarDetailDto> GetCarDetails()
        {
            using (HenRentACarContext context = new HenRentACarContext())
            {
                var result = from c in context.Cars
                    join cl in context.Colors on c.ColorId equals cl.Id
                    join b in context.Brands on c.BrandId equals b.Id
                    select new CarDetailDto
                    {
                        CarId = c.Id,
                        BrandName = b.BrandName,
                        ColorName = cl.ColorName,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetails2(Expression<Func<Car, bool>> filter = null)
        {
            using (HenRentACarContext context = new HenRentACarContext())
            {
                //return filter == null ? GetCarDetails() : GetCarDetails();

                if (filter == null)
                {
                    var result = from c in context.Cars
                        join cl in context.Colors on c.ColorId equals cl.Id
                        join b in context.Brands on c.BrandId equals b.Id
                        select new CarDetailDto
                        {
                            CarId = c.Id,
                            BrandName = b.BrandName,
                            ColorName = cl.ColorName,
                            DailyPrice = c.DailyPrice,
                            ModelYear = c.ModelYear,
                            Description = c.Description
                        };
                    return result.ToList();
                }
                else
                {
                    var result = from c in context.Cars where c.BrandId == 1
                        join cl in context.Colors on c.ColorId equals cl.Id
                        join b in context.Brands on c.BrandId equals b.Id
                        select new CarDetailDto
                        {
                            CarId = c.Id,
                            BrandName = b.BrandName,
                            ColorName = cl.ColorName,
                            DailyPrice = c.DailyPrice,
                            ModelYear = c.ModelYear,
                            Description = c.Description
                        };
                    return result.ToList();
                }
            }
        }

        //public List<CarDetailDto> GetCarDetails2(Expression<Func<CarDetailDto, bool>> filter = null)
        //{
        //    using (HenRentACarContext context = new HenRentACarContext())
        //    {
        //        return filter == null ? context.Set<CarDetailDto>().ToList() : context.Set<CarDetailDto>().Where(filter).ToList();
        //    }
        //}
    }

    //return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
}
