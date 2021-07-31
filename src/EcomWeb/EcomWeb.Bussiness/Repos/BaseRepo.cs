using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EcomWeb.Bussiness.Interfaces;
using EcomWeb.Bussiness.Interfaces.Repository;
using EcomWeb.DataAccessor.Data;
using Microsoft.EntityFrameworkCore;

namespace EcomWeb.Bussiness.Repos
{
    public class BaseRepo<T>: IBaseRepository<T> where T:class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Entities => _dbContext.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async  Task<T> GetByIdAsync(object id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async  Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(object id)
        {
            _dbContext.Remove<T>(this.GetByIdAsync(id).Result);
            await _dbContext.SaveChangesAsync();
        }

    }
}
