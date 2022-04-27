using Ef2504.DAL.Abstract;
using Ef2504.DAL.Concrete.EF;
using Ef2504.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_2504.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var _categories = new EFBaseRepository<Category>();
            return View(_categories.GetAll());
        }
    }
}
