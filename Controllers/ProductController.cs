using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Product;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>() {

         new Product
         {
            Id = 1,
            Name = "Samsung",
            Price = 2300m,
            ProductCount = 10,
            ReleaseDate = "2020",
        }



    };

        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Detail(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}
