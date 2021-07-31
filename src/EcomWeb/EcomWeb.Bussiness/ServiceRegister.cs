
using EcomWeb.Bussiness.Interfaces;
using EcomWeb.Bussiness.Interfaces.Repository;
using EcomWeb.Bussiness.Interfaces.Service;
using EcomWeb.Bussiness.Repos;
using EcomWeb.Bussiness.Services;
using EcomWeb.DataAccessor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EcomWeb.Bussiness
{
    public static class ServiceRegister
    {
        public static void AddBussinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessorLayer(configuration);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepo<>));
            services.AddTransient(typeof(IProductRepo<>), typeof(ProductRepo<>));

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
        }
    }
}