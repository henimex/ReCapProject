using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<HenRentACarContext, Brand>, IBrandDal
    {
    }
}
