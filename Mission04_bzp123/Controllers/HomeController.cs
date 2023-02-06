using Microsoft.AspNetCore.Mvc;
using Mission04_bzp123.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_bzp123.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Gradecalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gradecalculator(GradecalculatorModel model)
        {
            return View();
        }
    }
}
