using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcomWeb.Bussiness.Interface
{
    interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }

}
