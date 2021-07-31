using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using EcomWeb.Bussiness.Interfaces;
using EcomWeb.Bussiness.Interfaces.Repository;
using EcomWeb.Bussiness.Interfaces.Service;
using EcomWeb.Bussiness.Repos;
using EcomWeb.Contracts.Dtos;
using EcomWeb.DataAccessor.Entities;
using EnsureThat;

namespace EcomWeb.Bussiness.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo<Product> _productRepo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepo<Product> productRepo, IMapper mapper)
        {
            _productRepo =productRepo;
            _mapper = mapper;
        }

        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            Ensure.Any.IsNotNull(productDto, nameof(productDto));

            var product = _mapper.Map<Product>(productDto);

            var item = await _productRepo.AddAsync(product);
            return _mapper.Map<ProductDto>(item);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _productRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAllByIdParentAsync(Guid productId)
        {
            var products = await _productRepo.GetAllByIdParentAsync(productId);
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<IEnumerable<ProductDto>> GetAllFeaturedAsync()
        {
            var products = await _productRepo.GetAllFeaturedAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }
        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            Ensure.Any.IsNotNull(productDto, nameof(productDto));

            var product = _mapper.Map<Product>(productDto);

            await _productRepo.UpdateAsync(product);
        }

    }

}
