using DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetArticle()
        {
            var articles = Repository.AllArticles();

        }
    }
}
