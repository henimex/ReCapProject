using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IResult MakePayment(Payment payment);
    }
}
