using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Mypage()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contactus()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Form()
        {
            student s = new student();
            return View();
        }
        [HttpPost]
        public ActionResult Form(student s)
        {
            ViewBag.fname = s.fname;
            ViewBag.lname = s.lname;
            ViewBag.address = s.address;
            ViewBag.gender = s.Gender;
            ViewBag.city = s.city;

            return View();
        }

        
    }
}