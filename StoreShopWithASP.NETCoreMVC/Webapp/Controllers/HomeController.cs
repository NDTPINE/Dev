﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ct) => context = ct;
        public async Task<IActionResult> Index(long id = 1)
        {
            ViewBag.AveragePrice = await context.Products.AverageAsync(p => p.Price);
            return View(await context.Products.FindAsync(id));
        }
        
        public IActionResult List()
        {
            return View(context.Products);
        }
    }
}
