using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCalculator.Models;

namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Maths1 am)
        {
            am.error = " ";

            if (am.num2 == 0 && am.ops == "/")
            {
                am.error = "divide by zero";
            }
            else if (am.ops == "+")
            {
                am.result = am.num1 + am.num2;
            }
            else if (am.ops == "-")
            {
                am.result = am.num1 - am.num2;
            }
            else if (am.ops =="*")
            {
                am.result = am.num1 * am.num2;
            }
            else if (am.ops =="/")
            {
                am.result = am.num1 / am.num2;
            }
            
            return View(am);
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