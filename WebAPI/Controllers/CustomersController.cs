using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult Get(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}