using DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            
            var lessons = new List<Lesson>
            {
               new Lesson {ID=1, LessonName="HTML", Category="Frontend"},
               new Lesson {ID=2, LessonName="CSS", Category="Frontend"},
               new Lesson {ID=3, LessonName="Bootstrap", Category="Frontend"},
               new Lesson {ID=4, LessonName="JavaScript", Category="Frontend"},
               new Lesson {ID=5, LessonName="JQuery", Category="Frontend"},
               new Lesson {ID=6, LessonName="C#", Category="BackEnd"},
               new Lesson {ID=7, LessonName="PHP", Category="BackEnd"},


            };
            return View(lessons);
        }
    }
}
