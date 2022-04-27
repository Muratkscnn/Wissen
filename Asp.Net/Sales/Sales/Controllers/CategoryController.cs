using Microsoft.AspNetCore.Mvc;
using Sales.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var _context = new CategoryDAL();

            return View(_context.GetAll());
        }
    }
}
