using EcomWeb.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Bussiness.Interfaces.Service
{
    public interface IOrderService
    {
        public Task<OrderDto> GetByIdAsync(Guid id);

        public Task<OrderDto> AddAsync(OrderDto productDto);

        public Task DeleteAsync(Guid id);

        public Task UpdateAsync(OrderDto productDto);
        public Task<IEnumerable<ShoppingCartItemDto>> GetAllOrderItem();
    }
}
