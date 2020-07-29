﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Teacher_Demo_ConsoleUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }

        
    }
}
