﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.d1 = "/Dashboard/Index";
            return View();
        }
    }
}
