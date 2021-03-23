using System.Threading;
using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);
            var result = _carService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-cd")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-cd-carId")]
        public IActionResult GetCarDetailsByCarId(int id)
        {
            var result = _carService.GetCarDetailsByCar(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-cd-colorId")]
        public IActionResult GetCarDetailsByColor(int id)
        {
            var result = _carService.GetCarDetailsByColor(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-cd-brandId")]
        public IActionResult GetCarDetailsByBrand(int id)
        {
            var result = _carService.GetCarDetailsByBrand(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-cd-colorAndBrand")]
        public IActionResult GetCarDetailsByColorAndBrand(int colorId, int brandId)
        {
            var result = _carService.GetCarDetailsByColorAndBrand(colorId, brandId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }


    }
}