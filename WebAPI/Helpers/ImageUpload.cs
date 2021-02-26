﻿using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Business.Abstract;

namespace WebAPI.Helpers
{
    public class ImageUpload
    {
        private readonly string _imagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\";
        private ICarImageService _carImageService;
        private string _filePath = "";

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
            catch (Exception )
            {
            }

        }
    }
}
