using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult student()
        {
            return View();
        }
        public IActionResult studentID()
        {
            return View();
        }
        public IActionResult studentName()
        {
            return View();
        }
    }
}
