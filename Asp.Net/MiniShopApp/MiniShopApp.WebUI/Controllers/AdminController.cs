﻿using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Business.Concrete;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View(_productService.GetAll());
        }
        public IActionResult ProductCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductModel model,int[] categorysIds)
        {
            var product = new Product()
            {
                Name = model.Name,
                Url = model.Url,
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                IsApproved = model.IsApproved,
                IsHome = model.IsHome
            };
            _productService.Create(product,categorysIds);
            return RedirectToAction("ProductList");
        }
    }
}
