
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcomWeb.Contracts;
using EcomWeb.Contracts.Dtos;
namespace EcomWeb.Business.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDto>> GetAllAsync();

        public Task<CategoryDto> GetByIdAsync(Guid id);

        public Task<CategoryDto> AddAsync(CategoryDto categoryDto);

        public Task DeleteAsync(Guid id);

        public Task UpdateAsync(CategoryDto categoryDto);
    }

}
