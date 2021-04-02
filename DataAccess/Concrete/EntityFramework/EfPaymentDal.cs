using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : EfEntityRepositoryBase<HenRentACarContext, Payment>, IPaymentDal
    {
    }
}
