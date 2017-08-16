using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Infra.Models;
using Microsoft.AspNetCore.Mvc;
using AspNetSpa.Infra.Models.DTO;
using AspNetSpa.Infra.Models.Enum;
using NLog;

namespace AspNetSpa_Web.Controllers
{
    public class ProdController : BaseController
    {
        private readonly List<Product> _products = null;

        public ProdController()
        {
            this._products = new List<Product>();
            this._products.Add(new Product(){ Id="1", TypeId=(int)ProductTypeEnum.Book, Title="Book1", Price=100 });
            this._products.Add(new Product(){ Id="2", TypeId=(int)ProductTypeEnum.Book,Title="Book2", Price=200});
            this._products.Add(new Product(){ Id="3", TypeId=(int)ProductTypeEnum.Book,Title="Book3", Price=300 });            
            this._products.Add(new Product(){ Id="4", TypeId=(int)ProductTypeEnum.Toy,Title="Toy car", Price=400 });
            this._products.Add(new Product(){ Id="5", TypeId=(int)ProductTypeEnum.Toy, Title="Toy train", Price=500 });
            this._products.Add(new Product(){ Id="6", TypeId=(int)ProductTypeEnum.Clothing,Title="Blue T-shirt",Price=600 });
            this._products.Add(new Product(){ Id="7", TypeId=(int)ProductTypeEnum.Clothing,Title="Yellow skirt",Price=700 });
        }

        [Route("api/Prod/GetBooks")]
        public async Task<JsonResult> GetBooks()
        {
            return Json(this._products.Where(x=>x.TypeId.Equals((int)ProductTypeEnum.Book)));
        }

        [Route("api/Prod/GetToys")]
        public async Task<JsonResult> GetToys()
        {
            return Json(this._products.Where(x=>x.TypeId.Equals((int)ProductTypeEnum.Toy)));
        }

        [Route("api/Prod/GetClothes")]
        public async Task<JsonResult> GetClothes()
        {
            return Json(this._products.Where(x=>x.TypeId.Equals((int)ProductTypeEnum.Clothing)));
        }
    }
}