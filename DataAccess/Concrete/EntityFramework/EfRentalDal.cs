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
    public class EfRentalDal : EfEntityRepositoryBase<HenRentACarContext, Rental>, IRentalDal
    {
        public List<CarRentsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (HenRentACarContext context = new HenRentACarContext())
            {
                var result = from rnt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                    join c in context.Cars on rnt.CarId equals c.Id
                    join cu in context.Customers on rnt.CustomerId equals cu.Id
                    join br in context.Brands on c.BrandId equals br.Id
                    join us in context.Users on cu.UserId equals us.Id
                    select new CarRentsDto
                    {
                        Id = rnt.Id,
                        CarId = c.Id,
                        BrandName = br.BrandName,
                        CustomerName = us.FirstName,
                        CustomerSurname = us.LastName,
                        CustomerMail = us.Email,
                        Company = cu.CompanyName,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}
