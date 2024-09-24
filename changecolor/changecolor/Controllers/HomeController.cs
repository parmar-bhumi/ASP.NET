using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using changecolor.Models;

namespace changecolor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<student> studentList = new List<student>()
            {
                new student() {Id=1,fname="bhumi",lname="hello dear!!",age=21},
                new student() {Id=2,fname="krishna",lname="hello kisu!!",age=22},
                new student() {Id=3,fname="yachu",lname="bghg yachu!!",age=23}
            };
            return View(studentList);
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