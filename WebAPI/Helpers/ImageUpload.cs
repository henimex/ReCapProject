using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace WebAPI.Helpers
{
    public class ImageUpload
    {
        private readonly string _imagePath = Environment.CurrentDirectory + "\\Assets\\CarImages\\";

        public string UploadImage(IFormFile imageFile)
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
    }
}
