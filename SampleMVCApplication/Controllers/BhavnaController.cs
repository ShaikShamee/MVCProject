using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApplication.Controllers
{
    public class BhavnaController : Controller
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
