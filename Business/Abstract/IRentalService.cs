using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IDataResult<List<CarRentsDto>> GetDetailedRentals();
        IDataResult<List<CarRentsDto>> GetDetailedRentalsByCarId(int carId);
        IResult GetCarStatus(int carId);
        IResult RentedCarReturned(int carId);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult CheckRentStatus(Rental rental);
        List<string> GetDisabledDays(int carId);
    }
}
