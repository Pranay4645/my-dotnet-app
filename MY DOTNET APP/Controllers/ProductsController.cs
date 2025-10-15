using Microsoft.AspNetCore.Mvc;
using MyDotnetApp.Models;

namespace MyDotnetApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 80000 },
                new Product { Id = 2, Name = "Phone", Price = 50000 },
                new Product { Id = 3, Name = "Headphones", Price = 3000 }
            };
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = new Product { Id = id, Name = "Laptop", Price = 80000 };
            return View(product);
        }
    }
}
