using Core.DTO;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebKrot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _category;
        public CategoryController(ICategoryService category)
        {
            _category = category;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryGetByIdAsync(int id)
        {
            return Ok(await _category.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> CategoryGetAllAsync()
        {
            return Ok(await _category.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm]CreateCategoryDTO createCategoryDTO)
        {
            await _category.CreateAsync(createCategoryDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryByIDAsync(int id)
        {
            await _category.DeleteCategoryByIDAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct([FromForm]EditCategoryDTO editCategoryDTO)
        {
            await _category.EditAsync(editCategoryDTO);
            return Ok();
        }
    }
}
