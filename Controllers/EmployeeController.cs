﻿using Microsoft.AspNetCore.Mvc;

namespace PayRoll.Controllers
{
    public class EmployeeController : Controller
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