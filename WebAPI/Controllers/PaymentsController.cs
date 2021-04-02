using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entites.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("make-payment")]
        public IActionResult MakePayment(Payment payment)
        {
            //Thread.Sleep(5000);
            var result = _paymentService.MakePayment(payment);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}
