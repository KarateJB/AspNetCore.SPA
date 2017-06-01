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
        private IGuidServiceTransient _guidServiceTransient = null;
        private IGuidServiceScoped _guidServiceScoped = null;
        private IGuidServiceSingleton _guidServiceSingleton = null;
        private IGuidServiceSingletonInstance _guidServiceSingletonInstance = null;

        // public HomeController(
        //     IGuidServiceTransient guidServiceTransient,
        //     IGuidServiceScoped guidServiceScoped,
        //     IGuidServiceSingleton guidServiceSingleton,
        //     IGuidServiceSingletonInstance guidServiceSingletonInstance
        //      )
        // {
        //     this._guidServiceTransient = guidServiceTransient;
        //     this._guidServiceScoped = guidServiceScoped;
        //     this._guidServiceSingleton = guidServiceSingleton;
        //     this._guidServiceSingletonInstance = guidServiceSingletonInstance;
        // }

        public IActionResult Index()
        {
            // _logger.Debug($"Logging works!");

            // _logger.Info($"Transient : {this._guidServiceTransient.Id}");
            // _logger.Info($"Scoped : {this._guidServiceScoped.Id}");
            // _logger.Info($"Singleton : {this._guidServiceSingleton.Id}");
            // _logger.Info($"Instance : {this._guidServiceSingletonInstance.Id}");

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
