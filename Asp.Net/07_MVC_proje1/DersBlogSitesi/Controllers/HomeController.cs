using DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        List<Article> makaleler = new List<Article>
            {
            new Article {ID=1, Header="HTML", Content="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!"},
            new Article { ID = 2, Header = "CSS", Content = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!" },
            new Article { ID = 3, Header = "Bootstrap", Content = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!" },
            new Article { ID = 4, Header = "JavaScript", Content = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!" },
            new Article { ID = 5, Header = "C#", Content = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!" },
            new Article { ID = 6, Header = "JQuery", Content = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Necessitatibus eveniet fugiat voluptate natus quia dolor modi corporis cumque ad, nostrum, vel cupiditate sapiente atque quibusdam pariatur magni molestias accusantium deleniti omnis harum ducimus iste placeat aperiam commodi! Eveniet, ipsam beatae quas, rerum repudiandae inventore quae, est reprehenderit laboriosam sequi sit!" }

            };

        public IActionResult Index()
        {
            

            return View(makaleler);
        }
        public IActionResult HTML()
        {
            return View(makaleler);
        }
       
    }
}
