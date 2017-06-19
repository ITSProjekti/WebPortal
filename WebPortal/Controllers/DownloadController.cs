using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortal.Models;
using WebPortal.ViewModels;

namespace WebPortal.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Index(int id)
        {

          /*  using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                // Write the data to the file, byte by byte.
                for (int i = 0; i < bytes.Length; i++)
                {
                    fileStream.WriteByte(bytes[i]);
                }

                // Set the stream position to the beginning of the file.
                fileStream.Seek(0, SeekOrigin.Begin);
            }*/
            return View();
        }

         public ActionResult Downloads()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/Content/uploads/"));
            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*");
            List<string> items = new List<string>();

            foreach (var file in fileNames)
            {
                items.Add(file.Name);
            }

            return View(items);
        }

        public FileResult Download(string ImageName)
        {
            return File( "~/Content/uploads/" + ImageName, System.Net.Mime.MediaTypeNames.Application.Octet);
        }


    }
}