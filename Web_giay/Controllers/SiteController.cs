﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClassLibrary.Model;

namespace Web_giay.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site

        public ActionResult Index()
        {
            MyDBContext db = new MyDBContext();
            int somau = db.Products.Count();
            ViewBag.somau = somau;

            return View();
        }
        public ActionResult Name()
        {
            var n = 
        }
    }
}