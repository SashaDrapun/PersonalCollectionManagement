using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement
{
    public static class AppInviroment
    {
        public static IWebHostEnvironment AppEnvironment;

        public static async Task<string> CopyImage(CopyImageSettings copyImageSettings, IFormFile file)
        {
            string path = "/img/"+ copyImageSettings.ToString()+ "/";
            if (file != null)
            {
                path += file.FileName;

                using var fileStream = new FileStream(AppInviroment.AppEnvironment.WebRootPath + path, FileMode.Create);
                await file.CopyToAsync(fileStream);
            }
            return path;
        }
        public static void SetAppEnvironment(IWebHostEnvironment webHostEnvironment)
        {
            AppEnvironment = webHostEnvironment;
        }
    }
}
