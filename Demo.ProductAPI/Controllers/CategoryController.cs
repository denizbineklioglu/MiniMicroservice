using Demo.ProductAPI.Services;
using Demo.ProductAPI.Services.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Demo.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _service.GetCategoryList();
            if (categories != null)
            {
                return Ok(categories);
            }
            return BadRequest();
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _service.GetById(id);
            if (category != null)
            {
                return Ok(category);
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCategory(CategoryAddRequest model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateCategory(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id != null)
            {
                await _service.DeleteCategory(id);
                return Ok();
            }
            return BadRequest();    
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateCategory(model);
                return Ok($"{model.CategoryID} numaralı kategori güncellenmiştir.");
            }
            return BadRequest();
        }
    }
}
