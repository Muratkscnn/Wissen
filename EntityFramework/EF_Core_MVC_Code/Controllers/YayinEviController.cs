using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Core_MVC_Code.Controllers
{
    public class YayinEviController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public YayinEviController(KutuphaneSabahContext context)
        {
            _context=context;
            //bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni benim modelimi
            //temsil ediyor olacak, kütüphanesabahContexti temsil edecek.
        }
        public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
         public IActionResult Details(int id)
        {
            var yayinevleri=_context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        public IActionResult Edit(int id)
        {
            var yayinevleri=_context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        [HttpPost]
        public IActionResult Edit(Yayinevleri yayinevleri)
        {
            if (ModelState.IsValid)
            {
            _context.Update(yayinevleri);
            _context.SaveChanges();
             return RedirectToAction("Index");
            }
            return View(yayinevleri);
        }
        public IActionResult Delete(int id)
        {
            var yayinevleri=_context.Turlers.Find(id);
            return View(yayinevleri);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekyayinevi=_context.Yayinevleris.Find(id);
            _context.Yayinevleris.Remove(silinecekyayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Yayinevleri yayinevleri)
        {
            _context.Add(yayinevleri);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}