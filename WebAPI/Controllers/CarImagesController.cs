﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Entites.Concrete;
using WebAPI.Helpers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;
        private ImageUpload _imageUpload = new ImageUpload();

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-car-id")]
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetImagesByCarId(carId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageService.Add(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("addImage")]
        public IActionResult AddImage([FromForm] CarImage carImage, [FromForm] IFormFile image)
        {
            string imagePath = _imageUpload.CreatePath(image);
            if (imagePath == "0")
            {
                BadRequest(Messages.NullImagePath);
            }
            carImage.Date = DateTime.Now;
            carImage.ImagePath = imagePath;
            //carImage.CarId = 1;
            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, imagePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addImage3")]
        public IActionResult AddImage3([FromForm] CarImage carImage, [FromForm] IFormFile image)
        {
            var tempImage = _imageUpload.CreatePath2(carImage, image);

            var result = _carImageService.Add(tempImage);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, tempImage.ImagePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("updateImage")]
        public IActionResult UpdateImage([FromForm] CarImage carImage, [FromForm] IFormFile image)
        {
            string imagePath = _imageUpload.UploadImage(image, carImage.Id);
            if (imagePath == "0")
            {
                BadRequest(Messages.NullImagePath);
            }
            carImage.Date = DateTime.Now;
            carImage.ImagePath = imagePath;
            var result = _carImageService.Update(carImage);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("updateImage3")]
        public IActionResult UpdateImage3([FromForm] CarImage carImage, [FromForm] IFormFile image)
        {
            var tempImage = _imageUpload.CreatePath2(carImage, image);

            var result = _carImageService.Update(tempImage);
            if (result.Success)
            {
                _imageUpload.CopyFile(image, tempImage.ImagePath);
                _imageUpload.DeleteImageIfExists(1);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}