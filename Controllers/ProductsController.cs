using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using lr9api.Models;

namespace lr9api.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Sumsung a54 ", Price = 10000.0m },
                new Product { ID = 2, Name = "Sumsung S22 ", Price = 210000.0m },
                new Product { ID = 3, Name = "Sumsung S24", Price = 20000.0m }
            };

            return View(products);
        }
    }
}