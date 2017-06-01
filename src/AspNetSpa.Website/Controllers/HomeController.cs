using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSpa_Website.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            _logger.Debug($"Action: Index");

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
