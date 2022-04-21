using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Context;

namespace Controllers
{
    public class CategoryController : Controller
    {
        private readonly Library6Context _context;
        public CategoryController(Library6Context context)
        {
            _context=context;
            //bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni benim modelimi
            //temsil ediyor olacak, kütüphanesabahContexti temsil edecek.
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}