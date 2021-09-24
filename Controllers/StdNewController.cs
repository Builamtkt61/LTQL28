using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL28.Models;

namespace LTQL28.Controllers
{
    public class StdNewController : Controller
    {
        LapTrinhQuanLyDbContext db = new LapTrinhQuanLyDbContext();
        AutoGenerateKey genKey = new AutoGenerateKey();
        // GET: StdNew
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            var stdID = "";
            var countStudent = db.Students.Count();
            if (countStudent == 0)
            {
                stdID = "STD001";
            }
            else
            {
                var studentID = db.Students.ToList().OrderByDescending(m => m.StudentID).FirstOrDefault().StudentID;
                stdID = genKey.GenerateKey(studentID);
            }
            ViewBag.studentID = stdID;
            return View();
        }
        [HttpPost]

        public ActionResult Create(Student std)
        {
            var countStudent = db.Students.Count();
            if (countStudent==0)
            {
                std.StudentID = "STD001";
            }
            else 
            { 
                var studentID = db.Students.ToList().OrderByDescending(m => m.StudentID).FirstOrDefault().StudentID;
                std.StudentID = genKey.GenerateKey(studentID);
            }
            db.Students.Add(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}