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
                    join br in context.Brands on rnt.
            }
            
        }
    }
}
