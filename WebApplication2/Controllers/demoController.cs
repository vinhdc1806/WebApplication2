﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class demoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public string chuoi()
        {
            return "hello";
        }
        public IActionResult demo()
        {
            return View();
        }
    }
}