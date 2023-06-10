using Microsoft.AspNetCore.Mvc;
using WorkShop1_WebApp.Models;

namespace WorkShop1_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private int pageSize=4;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(int pageNumber=1)
        {
            return View(productRepository.GetAll(pageNumber,pageSize));
        }
    }
}
