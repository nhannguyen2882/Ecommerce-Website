using EcomWeb.Bussiness.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace EcomWeb.WebApp.ViewComponents
{
    public class ProductFeaturedViewComponent : ViewComponent
    {

        private readonly IProductService _productService;


        public ProductFeaturedViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var res = await _productService.GetAllFeaturedAsync();
            return View(res);
        }
    
    }
}
