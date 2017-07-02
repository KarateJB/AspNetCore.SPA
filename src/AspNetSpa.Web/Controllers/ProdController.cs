using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Infra.Models;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace AspNetSpa_Web.Controllers
{
    public class ProdController : BaseController
    {
        private readonly List<Product> _products = null;

        public ProdController()
        {
            this._products = new List<Product>();
            this._products.Add(new Product(){ Id="1", Title="Book1" });
            this._products.Add(new Product(){ Id="2", Title="Book2" });
        }

        [Route("api/prod/GetBooks")]
        public async Task<JsonResult> GetBooks()
        {
            return Json(this._products);
        }
    }
}