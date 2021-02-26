using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Helpers
{
    public class ImageUpload : IImageUpload
    {
        private string ImagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\";

        public string UploadImage(IFormFile imageFile)
        {
            try
            {
                if (imageFile.Length > 0)
                {
                    if (!Directory.Exists(ImagePath))
                    {
                        Directory.CreateDirectory(ImagePath);
                    }

                    FileInfo fileInfo = new FileInfo(ImagePath + imageFile.FileName);
                    var fileExtension = fileInfo.Extension;
                    var gName = Guid.NewGuid().ToString("n");
                    var filePath = ImagePath + gName + fileExtension;
                    
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
    }
}
