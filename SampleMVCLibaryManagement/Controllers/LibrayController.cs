using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCLibaryManagement.Controllers
{
    public class LibrayController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
