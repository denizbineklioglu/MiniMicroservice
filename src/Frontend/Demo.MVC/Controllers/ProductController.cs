using Demo.MVC.Models.Product;
using Demo.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProducts();
            return View(products);
        }

        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetCategories();
            ViewBag.categories = new SelectList(categories, "CategoryID", "CategoryName"); ;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ImageUrl = model.Image.FileName;
                var result = await _productService.CreateProduct(model);
                if (result)
                {
                    return RedirectToAction("GetProducts");
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProduct(id);
            return RedirectToAction("GetProducts");
               
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await _productService.GetProductById(id);

            var categories = await _categoryService.GetCategories();
            ViewBag.categories = new SelectList(categories, "CategoryID", "CategoryName"); ;

            ProductUpdateModel model = new ProductUpdateModel()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryID = product.CategoryID,
                ImageUrl =  product.ImageUrl,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateProduct(model);
                return RedirectToAction("GetProducts");
            }
            return View();
        }
    }
}
