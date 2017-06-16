using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace AspNetSpa_Web.Controllers
{
    public class BaseController : Controller
    {
        protected static Logger _logger = LogManager.GetCurrentClassLogger();
    }
}