using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcomWeb.Contracts.Dtos;
namespace EcomWeb.Bussiness.Interfaces.Service
{
    public interface IProductService
    {
        public Task<ProductDto> GetByIdAsync(Guid id);

        public Task<ProductDto> AddAsync(ProductDto productDto);

        public Task DeleteAsync(Guid id);

        public Task UpdateAsync(ProductDto productDto);
        public Task<IEnumerable<ProductDto>> GetAllByIdParentAsync(Guid categoryId);
        public Task<IEnumerable<ProductDto>> GetAllFeaturedAsync();
    }
}
