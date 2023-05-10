using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Product;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
    List<Product> products = new List<Product>();

        public IActionResult Index()
        {

            return View();
        }
    }
}
