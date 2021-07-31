using EcomWeb.Bussiness.Interfaces;
using EcomWeb.Bussiness.Interfaces.Service;
using EcomWeb.Contracts.Dtos;
using EcomWeb.WebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomWeb.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        // GET: CategoryController
        [HttpGet]
        [Route("[controller]/[action]/{id?}")]
        public ActionResult Details(Guid id)
        {
            var categoryViewModel = new CategoryViewModel() 
            {
                categoryDto = _categoryService.GetByIdAsync(id).Result,
                productDtos = _productService.GetAllByIdParentAsync(id).Result
            };

            return View(categoryViewModel);
        }
    } 
}
