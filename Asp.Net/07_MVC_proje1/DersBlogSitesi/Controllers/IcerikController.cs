using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class IcerikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
