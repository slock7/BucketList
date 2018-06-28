using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using BucketList.Models;
//*Directory
using Microsoft.AspNetCore.Http;    //*IFormFile
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting; //*get RootPath

namespace BucketList.Controllers
{
    public class ImageController : Controller

    {

        private readonly IHostingEnvironment _appEnvironment;

        public ImageController(IHostingEnvironment appEnvironment)
        {
            //----< Init: Controller >----
            _appEnvironment = appEnvironment;
        }


        [HttpGet] //1.Load
        public IActionResult Upload_Image()
        {
            //--< Upload Form >--
            return View();
        }

        [HttpPost] //Postback
        public async Task<IActionResult> Upload_Image(IFormFile file)
        {
            //--------< Upload_ImageFile() >--------
            //< check >
            if (file == null || file.Length == 0) return Content("file not selected");


            //< get Path >
            string path_Root = _appEnvironment.WebRootPath;

            string path_to_Images = path_Root + "\\img\\" + file.FileName;


            //< Copy File to Target >
            using (var stream = new FileStream(path_to_Images, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }


            //< output >
            ViewData["FilePath"] = path_to_Images;
            return View();
            //--------</ Upload_ImageFile() >--------
        }
    }
}