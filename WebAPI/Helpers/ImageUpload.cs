using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace WebAPI.Helpers
{
    public class ImageUpload
    {
        private readonly string _imagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\";
        private ICarImageService _carImageService;
        //private string _filePath = "";
        private string defaultImagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\" + "default.jpg";

        public ImageUpload(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        public ImageUpload()
        {
        }

        public string UploadImage(IFormFile imageFile, int imageId = 0)
        {
            try
            {
                if (imageFile.Length > 0)
                {
                    if (!Directory.Exists(_imagePath)) Directory.CreateDirectory(_imagePath);

                    FileInfo fileInfo = new FileInfo(_imagePath + imageFile.FileName);
                    var fileExtension = fileInfo.Extension;
                    var gName = Guid.NewGuid().ToString("n");
                    var filePath = _imagePath + gName + fileExtension;

                    using (FileStream fileStream = File.Create(filePath))
                    {
                        imageFile.CopyTo(fileStream);
                        fileStream.Flush();
                    }

                    return filePath;
                }
            }
            catch
            {
                return "0";
            }

            return null;
        }

        public string CreatePath(IFormFile imageFile)
        {
            try
            {
                if (imageFile.Length > 0)
                {
                    if (!Directory.Exists(_imagePath)) Directory.CreateDirectory(_imagePath);
                    FileInfo fileInfo = new FileInfo(_imagePath + imageFile.FileName);
                    var fileExtension = fileInfo.Extension;
                    var gName = Guid.NewGuid().ToString("n");
                    var filePath = _imagePath + gName + fileExtension;
                    return filePath;
                }
            }
            catch (Exception)
            {
                return "0";
            }

            return null;
        }

        public void CopyFile(IFormFile imageFile, string filePath)
        {
            using (FileStream fileStream = File.Create(filePath))
            {
                imageFile.CopyTo(fileStream);
                fileStream.Flush();
            }
        }

        public void DeleteImageIfExists(int createdImageId)
        {
            try
            {
                var result = _carImageService.GetById(createdImageId);
                if (result.Success)
                {
                    var fileToDelete = result.Data.ImagePath;
                    File.Delete(fileToDelete);
                    //return true;
                }

                //return false;
            }
            catch (Exception)
            {
            }
        }

        public void DeleteImageIfExists2(string path)
        {
            File.Delete(path);
        }

        public CarImage CreatePath2([FromForm] CarImage carImage, IFormFile imageFile)
        {
            string imagePath = "";
            try
            {
                if (imageFile.Length > 0)
                {
                    if (!Directory.Exists(_imagePath)) Directory.CreateDirectory(_imagePath);
                    FileInfo fileInfo = new FileInfo(_imagePath + imageFile.FileName);
                    var fileExtension = fileInfo.Extension;
                    var gName = Guid.NewGuid().ToString("n");
                    var filePath = _imagePath + gName + fileExtension;
                    imagePath = filePath;
                }
            }
            catch (Exception)
            {
                throw new Exception("Image Path Is Null or Empty");
            }

            carImage.Date = DateTime.Now;
            carImage.ImagePath = imagePath;
            carImage.CarId = carImage.CarId;
            return carImage;
        }
    }
}