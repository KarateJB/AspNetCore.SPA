using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSpa_Website.Controllers
{
    public class DIdemoController : BaseController
    {
        private IGuidServiceTransient _guidServiceTransient = null;
        private IGuidServiceScoped _guidServiceScoped = null;

        // private IGuidServiceTransient _guidServiceTransientDup = null;
        // private IGuidServiceScoped _guidServiceScopedDup = null;

        private IGuidServiceSingleton _guidServiceSingleton = null;
        private IGuidServiceSingletonInstance _guidServiceSingletonInstance = null;

        public DIdemoController(
            IGuidServiceTransient guidServiceTransient,
            IGuidServiceScoped guidServiceScoped,
            // IGuidServiceTransient guidServiceTransientDup,
            // IGuidServiceScoped guidServiceScopedDup)
            IGuidServiceSingleton guidServiceSingleton,
            IGuidServiceSingletonInstance guidServiceSingletonInstance
             )
        {
            this._guidServiceTransient = guidServiceTransient;
            this._guidServiceScoped = guidServiceScoped;
            // this._guidServiceTransientDup = guidServiceTransientDup;
            // this._guidServiceScopedDup = guidServiceScopedDup;
            this._guidServiceSingleton = guidServiceSingleton;
            this._guidServiceSingletonInstance = guidServiceSingletonInstance;
        }

        public IActionResult Index()
        {
            _logger.Debug($"Action: Index");

            _logger.Info($"Transient : {this._guidServiceTransient.Id}");
            _logger.Info($"Scoped : {this._guidServiceScoped.Id}");
            // _logger.Info($"Transient(2) : {this._guidServiceTransientDup.Id}");
            // _logger.Info($"Scoped(2) : {this._guidServiceScopedDup.Id}");
            _logger.Info($"Singleton : {this._guidServiceSingleton.Id}");
            _logger.Info($"Instance : {this._guidServiceSingletonInstance.Id}");
            return View();
        }

    }
}
