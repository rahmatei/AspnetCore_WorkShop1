using Microsoft.AspNetCore.Mvc;
using WorkShop1_WebApp.Models;

namespace WorkShop1_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.GetAll());
        }
    }
}
