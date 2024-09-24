using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]

        public ActionResult About(string fname,string lname)
        {
            //string name = f["fname"];
            //string lname = f["lname"];
            return View();
        }
        

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(string no1, string no2, string opration)
        {
            int number1 = int.Parse(no1);
            int number2 = int.Parse(no2);

            int result = 0;

            switch (opration)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        ViewBag.Error = "Cannot divide by zero.";
                        return View();
                    }
                    result = number1 / number2;
                    break;
                default:
                    ViewBag.Error = "Invalid operation.";
                    return View();
            }

            ViewBag.Num1 = number1;
            ViewBag.Num2 = number2;
            ViewBag.Result = result;
            ViewBag.Operation = opration;

            return View();
        }
    }
}
    
