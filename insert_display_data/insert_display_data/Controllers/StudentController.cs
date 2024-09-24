using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insert_display_data.Models;

namespace insert_display_data.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            myDBEntities db = new myDBEntities();
            List<Student> std = db.Students.ToList();
            return View(std);
        }

        public ActionResult Registration()
        {
           
            return View();
        }
        [HttpPost]

        public ActionResult Registration(Student s)
        {
            myDBEntities db = new myDBEntities();
            db.Students.Add(s);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            myDBEntities db = new myDBEntities();
            //Student student = db.Students.SingleOrDefault(Id);
            Student student = db.Students.Find(Id);
            db.Students.Remove(student);
            db.SaveChanges();
            //TempData["AlertMessage"] = "Item deleted successfully.";
            return RedirectToAction("Index");
        }

        public ActionResult edit(int Id)
        {

            return View();
        }    
}
}