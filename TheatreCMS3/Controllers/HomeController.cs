using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheatreCMS3.Models;


namespace TheatreCMS3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() => View();

        public ActionResult SuccessMessage() => View();

        public ActionResult SignIn() => View();

        public ActionResult Donate() => View();

    }
}