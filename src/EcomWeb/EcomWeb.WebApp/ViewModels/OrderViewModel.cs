using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcomWeb.Contracts.Dtos;
namespace EcomWeb.WebApp.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<ShoppingCartItemDto> CartItemDtos{ get; set; }

        public OrderDto orderDto{ get; set; }
    }
}
