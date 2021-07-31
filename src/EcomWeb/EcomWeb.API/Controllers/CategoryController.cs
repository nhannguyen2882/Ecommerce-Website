using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcomWeb.DataAccessor.Data;
using EcomWeb.DataAccessor.Entities;
using EcomWeb.Bussiness.Interfaces.Service;
using EcomWeb.Contracts.Dtos;

namespace EcomWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
            return await _categoryService.GetAllAsync();
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<CategoryDto> GetCategory(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            return category;
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(Guid id, CategoryDto category)
        {
            Console.WriteLine(id.ToString());
            if (id != category.Id)
            {
                return BadRequest();
            }

            await _categoryService.UpdateAsync(category);


            return NoContent();
        }

        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> PostCategory(CategoryDto category)
        {
            Console.WriteLine(category.Name.ToString());
            await _categoryService.AddAsync(category);

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryService.DeleteAsync(id);

            return NoContent();
        }

    }
}
