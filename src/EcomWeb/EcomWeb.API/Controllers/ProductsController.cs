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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetProducts(Guid categoryId)
        {
            return await _productService.GetAllByIdParentAsync(categoryId);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ProductDto> GetProduct(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            return product;
        }

        // PUT: api/Product/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(Guid id, ProductDto product)
        {
            Console.WriteLine(id.ToString());
            if (id != product.Id)
            {
                return BadRequest();
            }

            await _productService.UpdateAsync(product);


            return NoContent();
        }

        // POST: api/Product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostProduct(ProductDto product)
        {
            Console.WriteLine(product.Name.ToString());
            await _productService.AddAsync(product);

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteAsync(id);

            return NoContent();
        }

    }
}
