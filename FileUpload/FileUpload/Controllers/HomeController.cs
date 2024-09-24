using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase f)
        {
            if (f == null)
            {
                ViewBag.Message = "No file was uploaded.";
                return View();
            }

            string[] allowedExtensions = {  ".jpg",".png", ".gif" };
            string fileExtension = Path.GetExtension(f.FileName).ToLower();

            if (!allowedExtensions.Contains(fileExtension))
            {
                ViewBag.Message = "Only image files are allowed.";
                return View();
            }

            string filename = Guid.NewGuid().ToString() + fileExtension;
            string path = Server.MapPath("~/uploads/") + filename;

            try
            {
                f.SaveAs(path);
                ViewBag.Message = "File uploaded successfully.";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}


