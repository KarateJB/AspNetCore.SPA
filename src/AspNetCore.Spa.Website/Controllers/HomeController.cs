using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Spa_Website.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            _logger.Debug($"Logging works!");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
