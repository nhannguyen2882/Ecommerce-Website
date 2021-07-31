using EcomWeb.Contracts.Dtos;
using EcomWeb.Bussiness.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomWeb.WebApp.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryDto categoryDto{ get; set; }

        public IEnumerable<ProductDto> productDtos{ get; set; }
    }
}
