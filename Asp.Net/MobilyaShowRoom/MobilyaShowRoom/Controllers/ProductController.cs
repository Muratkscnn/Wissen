using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Repository.AllProducts();
            return View(products);
        }
        public IActionResult GetProductDetail()
        {
            var products = Repository.AllProducts();
            Product resultProduct = null;
            int id =Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            foreach (var item in products)
            {
                if (item.ID==id)
                {
                    resultProduct = item;
                    break;
                }
            }
            ViewBag.Product = resultProduct;
            return View();
        }
    }
}
