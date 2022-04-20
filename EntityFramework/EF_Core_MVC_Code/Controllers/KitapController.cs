using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_MVC_Code.Controllers
{
    public class KitapController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public KitapController(KutuphaneSabahContext context)
        {
            _context=context;
            //bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni benim modelimi
            //temsil ediyor olacak, kütüphanesabahContexti temsil edecek.
        }

         public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
         public IActionResult Details(string id)
        {
            var kitap=_context.Kitaplars.Include(k => k.Tur)
            .Include(k => k.YayinEvi)
            .Include(k => k.Yazar)
            .First(sk =>sk.Isbn==id);
            return View(kitap);
        }
        public IActionResult Edit(string id)
        {
            var kitap=_context.Kitaplars.Find(id);
            ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd",kitap.TurId);
            ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad",kitap.YazarId);
            ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad",kitap.YayinEviId);

            return View(kitap);
        }
        [HttpPost]
        public IActionResult Edit(Kitaplar kitap)
        {
            if (ModelState.IsValid)
            {
            _context.Update(kitap);
            _context.SaveChanges();
             return RedirectToAction("Index");
            }
            return View(kitap);
        }
        public IActionResult Delete(int id)
        {
            var kitap=_context.Kitaplars.Find(id);
            return View(kitap);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekkitap=_context.Kitaplars.Find(id);
            _context.Kitaplars.Remove(silinecekkitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd");
            ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad");
            ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad");

            return View();
        }
        [HttpPost]
        public IActionResult Create(Kitaplar kitap)
        {
            _context.Add(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}