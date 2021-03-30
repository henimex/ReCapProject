using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-rd")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetDetailedRentals();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-rd-car-id")]
        public IActionResult GetRentalDetailsByCarId(int carId)
        {
            var result = _rentalService.GetDetailedRentalsByCarId(carId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("get-dis-days")]
        public IActionResult GetDisableDays(int carId)
        {
            var result = _rentalService.GetDisabledDays(carId);
            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest("Disabled Days Count is : " + result.Count);
        }

        [HttpGet("check-available")]
        public IActionResult CheckAvailability(Rental rental)
        {
            var result = _rentalService.CheckRentStatus(rental);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

    }
}