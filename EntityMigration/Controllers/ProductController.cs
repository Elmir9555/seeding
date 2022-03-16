using EntityMigration.Data;
using EntityMigration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityMigration.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.ProductCount = _context.Products.Where(a => a.IsDeleted == false).Count();
            Setup setups =await  _context.Setups.FirstOrDefaultAsync();
            List<Product> products = await _context.Products.Where(a => a.IsDeleted == false)
               .Include(m => m.Category)
               .Include(m => m.Images)
               .Take(setups.HomeProductTake)
               .ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> LoadMore(int skip)
        {
            Setup setups = await _context.Setups.FirstOrDefaultAsync();
            List<Product> products = await _context.Products.Where(a => a.IsDeleted == false)
              .Include(m => m.Category)
              .Include(m => m.Images)
              .Skip(skip)
              .Take(setups.Load)
              .ToListAsync();

            return PartialView("_ProductsPartial", products);
        }
    }
}
