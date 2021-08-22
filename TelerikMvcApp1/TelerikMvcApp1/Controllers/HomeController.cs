﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikMvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        //tue sua ngay 23/8
        [ActionName("lienhe")]
        [HttpPost]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("lienhe");
        }
    }
}
