using EcomWeb.DataAccessor.Data;
using EcomWeb.DataAccessor.Entities;
using EcomWeb.Bussiness.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcomWeb.Bussiness.Interfaces.Repository;

namespace EcomWeb.Bussiness.Repos
{
    public class ProductRepo<T> : IProductRepo<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<T> Entities => throw new NotImplementedException();

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(object id)
        {
            _dbContext.Remove<T>(this.GetByIdAsync(id).Result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllByIdParentAsync(Guid categoryId)
        {
            return (IEnumerable<T>)await _dbContext.Set<Product>().Where(c=>c.CategoryId == categoryId).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllFeaturedAsync()
        {
            return (IEnumerable<T>)await _dbContext.Set<Product>().Where(c => c.IsFeatured == true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
