using Registrationform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registrationform.Controllers
{
    public class HomeController : Controller
    {

        mydbEntities db = new mydbEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<student> s = db.students.ToList();
            return View(s);
        }

        public ActionResult registration(student s)
        {
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}