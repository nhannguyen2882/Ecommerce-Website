using EcomWeb.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Bussiness.Interfaces.Repository
{
    public interface IProductRepo<T> : IBaseRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllByIdParentAsync(Guid categoryId);
        public Task<IEnumerable<T>> GetAllFeaturedAsync();
    }
}
