using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class BookController : Controller
    {
       private readonly Library6Context  _context;
        public BookController(Library6Context context)
        {
            _context=context;
           
        }

        public IActionResult Index()
        {
            return View(_context.Books.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult Create()
        {
            ViewData["Category"]=new SelectList(_context.Categories.Where(x=>x.IsDeleted==false).ToList(),"CategoryId","CategoryName");
            ViewData["Author"]=new SelectList(_context.Authors.Where(x=>x.IsDeleted==false).ToList(),"AuthorId","AuthorName");
            ViewData["Publisher"]=new SelectList(_context.Publishers.Where(x=>x.IsDeleted==false).ToList(),"PublisherId","PublisherName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return View();
        }
         public IActionResult Details(int id)
        {
            var kitap=_context.Books.Include(k => k.Category)
            .Include(k => k.Publisher)
            .Include(k => k.Author)
            .First(sk =>sk.BookId==id);
            return View(kitap);
        }
        public IActionResult Edit(int id)
        {
            var kitap=_context.Books.Find(id);
            ViewData["Category"]=new SelectList(_context.Categories.Where(x=>x.IsDeleted==false).ToList(),"CategoryId","CategoryName",kitap.CategoryId);
            ViewData["Author"]=new SelectList(_context.Authors.Where(x=>x.IsDeleted==false).ToList(),"AuthorId","AuthorName",kitap.AuthorId);
            ViewData["Publisher"]=new SelectList(_context.Publishers.Where(x=>x.IsDeleted==false).ToList(),"PublisherId","PublisherName",kitap.PublisherId);
            return View(kitap);
        }
        [HttpPost]
        public IActionResult Edit(Book kitap)
        {
            if (ModelState.IsValid)
            {
            _context.Update(kitap);
            _context.SaveChanges();
             return RedirectToAction("Index");
            }
            return View(kitap);
        }

    }
}