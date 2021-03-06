﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<CarRentsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
        List<RentDto> GetRentalTest(Expression<Func<Rental, bool>> filter = null);
    }
}
