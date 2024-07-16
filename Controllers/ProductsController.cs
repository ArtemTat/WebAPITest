using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;



namespace WebAPI.Controllers
{
    [Route("/api/[controller]")]

    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>(new[] {
            new Product() {Id = 1, Name = "Bike", Price = 10000},
            new Product() {Id = 2, Name = "Car", Price = 300000},
            new Product() {Id = 3, Name = "Bus", Price = 500000}
        });

        [HttpGet]
        public IEnumerable<Product> Get() => products;

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
