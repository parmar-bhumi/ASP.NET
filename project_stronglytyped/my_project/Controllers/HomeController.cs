using my_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using my_project.Models;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<student> studentList = new List<student>()
            {
                new student() {Id=1,Name="bhumi",Description="hello dear!!",Mobile=757486828},
                new student() {Id=2,Name="krishna",Description="hello kisu!!",Mobile=7776767},
                new student() {Id=3,Name="yachu",Description="bghg yachu!!",Mobile=7676767}
            };
            return View(studentList);
            //student s = new student();
            //s.Id = 1;
            //s.Name = "Test";
            //s.Description = "Hello dear!!";
            //s.Mobile = 23444444;
            //return View(s);
        }
        public ActionResult About()
        {
            ViewBag.skill = new List<string>() { "Reading", "Drawing" };
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        

        public static class StringHelper
        {
            public static string ReverseString(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return str;

                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }

    }
}