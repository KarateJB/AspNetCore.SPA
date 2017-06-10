using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Infra.Utility;
using AspNetSpa.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSpa_Website.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
        }

        //[Route("[controller]/[action]/{name:Custom}")]
        public IActionResult Index(string name)
        {
            _logger.Debug($"Name={name}");
            return View();
        }
        
        public IActionResult Help(string question)
        {
            ViewBag.Question = question;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
