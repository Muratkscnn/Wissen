using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class MiniShopController : Controller
    {
        IProductService _product;

        public MiniShopController(IProductService product)
        {
            _product = product;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string Category)
        {

            return View(_product.GetProductsByCategory(Category)); 
        }
    }
}
