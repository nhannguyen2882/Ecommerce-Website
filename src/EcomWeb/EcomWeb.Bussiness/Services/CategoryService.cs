using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EcomWeb.Business.Interfaces;
using EcomWeb.Bussiness.Interface;
using EcomWeb.Contracts.Dtos;
using EcomWeb.DataAccessor.Entities;
using EnsureThat;

namespace EcomWeb.Bussiness.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _baseRepository;
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<Category> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            var category = _mapper.Map<Category>(categoryDto);
            var item = await _baseRepository.AddAsync(category);
            return _mapper.Map<CategoryDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetByIdAsync(Guid id)
        {
            var category = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
