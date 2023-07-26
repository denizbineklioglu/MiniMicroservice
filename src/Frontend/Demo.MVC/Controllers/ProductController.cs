using Demo.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProducts();
            return View(products);
        }
    }
}
