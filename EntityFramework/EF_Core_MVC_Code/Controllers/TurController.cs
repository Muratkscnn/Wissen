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
   
    public class TurController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public TurController(KutuphaneSabahContext context)
        {
            _context=context;
            //bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni benim modelimi
            //temsil ediyor olacak, kütüphanesabahContexti temsil edecek.
        }
        public IActionResult Index()
        {

            return View(_context.Turlers.ToList());
        }

        public IActionResult Details(int id)
        {
            var tur=_context.Turlers.Find(id);
            return View(tur);
        }
        public IActionResult Edit(int id)
        {
            var tur=_context.Turlers.Find(id);
            return View(tur);
        }
        [HttpPost]
        public IActionResult Edit(Turler tur)
        {
            if (ModelState.IsValid)
            {
            _context.Update(tur);
            _context.SaveChanges();
             return RedirectToAction("Index");
            }
            return View(tur);
        }
        public IActionResult Delete(int id)
        {
            var tur=_context.Turlers.Find(id);
            return View(tur);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekKitapTuru=_context.Turlers.Find(id);
            _context.Turlers.Remove(silinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Turler tur)
        {
            _context.Add(tur);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}