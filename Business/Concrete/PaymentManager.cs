using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class PaymentManager: IPaymentService
    {
        private IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IResult MakePayment(Payment payment)
        {
            payment.PaymentDay = DateTime.Now;
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentSuccessFull);
        }
    }
}
