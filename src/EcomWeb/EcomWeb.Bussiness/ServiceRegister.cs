using EcomWeb.DataAccessor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcomWeb.Bussiness
{
    public static class ServiceRegister
    {
        public static void AddBussinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessorLayer(configuration);
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}