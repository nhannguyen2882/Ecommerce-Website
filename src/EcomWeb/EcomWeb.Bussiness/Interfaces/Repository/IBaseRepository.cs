using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomWeb.Bussiness.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(object id);
        public Task<T> AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(object id);
    }

}
