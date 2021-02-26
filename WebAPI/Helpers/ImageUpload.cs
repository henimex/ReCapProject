using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Business.Abstract;

namespace WebAPI.Helpers
{
    public class ImageUpload
    {
        private readonly string _imagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\";
        private ICarImageService _carImageService;

        public ImageUpload(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        public ImageUpload()
        {
        }

        public string UploadImage(IFormFile imageFile,int imageId=0)
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
                        DeleteImageIfExists(imageId);
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

        public void DeleteImageIfExists(int Id)
        {
            var result = _carImageService.GetById(Id);
            if (result.Success)
            {
                var fileToDelete = result.Data.ImagePath;
                File.Delete(fileToDelete);
                //return true;
            }
            
            //return false;
        }
    }
}
