﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrangChu.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult tintuc()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult gioithieu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult sanpham()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult chitietsp()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult vechungtoi()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}