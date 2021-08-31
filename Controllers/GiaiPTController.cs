using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;

namespace LTQL28.Controllers
{
    public class GiaiPTController : Controller
    {
        giaiphuongtrinh gpt = new giaiphuongtrinh();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Giaiptb1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giaiptb1(string a, string b)
        {
            try
            {
                double soA = Convert.ToDouble(a);
                double soB = Convert.ToDouble(b);
                Double x = gpt.giaipt(soA, soB);
                ViewBag.nghiemPT = x;
            }
            catch (Exception)
            {
                ViewBag.nghiemPT = "Kiểu dữ liệu đầu vào không đúng";
            }
            return View();
        }


    }
}