﻿using Microsoft.AspNetCore.Mvc;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
