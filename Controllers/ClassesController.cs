using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassMate.Models;

namespace ClassMate.Controllers
{
    public class ClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult GermanClass()
        {
            ViewData["Message"] = "Welcome to your german class!";
            return View();
        }
    }

}
