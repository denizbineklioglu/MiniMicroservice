using Demo.ProductAPI.Services;
using Demo.ProductAPI.Services.dtos;
using Demo.ProductAPI.Services.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Demo.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _service.GetProducts();
            if (products != null)
            {
                return Ok(products);
            }
            return BadRequest();
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            if (id != null)
            {
                var product = await _service.GetById(id);
                if (product != null)
                {
                    return Ok(product);
                }
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProduct(ProductAddRequestDto model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateProduct(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id != null)
            {
                await _service.DeleteProduct(id);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateProduct(model);
                return Ok($"{model.ProductID} numaralı ürün güncellenmiştir.");
            }
            return BadRequest();
        }

    }
}
