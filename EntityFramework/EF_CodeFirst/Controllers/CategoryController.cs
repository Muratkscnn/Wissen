using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class CategoryController :Controller
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

            return View(_context.Categories.Where(e => e.IsDeleted==false).ToList());
        }

        public IActionResult Details(int id)
        {
            var tur=_context.Categories.Find(id);
            return View(tur);
        }
        public IActionResult Edit(int id)
        {
            var category=_context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            
            _context.Update(category);
            _context.SaveChanges();
             return RedirectToAction("Index");
            
        }
        public IActionResult Delete(int id)
        {
            var category=_context.Categories.Find(id);

            return View(category);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekCategory=_context.Categories.Find(id);
            silinecekCategory.IsDeleted=true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}