﻿using System.Linq;
using System.Threading.Tasks;

namespace UF5423_SuperShop.Data
{
    public interface IGenericRepository<T> where T : class // Generic entity repository interface. // Does not require instantiation when inherited by other interfaces.
    {
        IQueryable<T> GetAll(); // List that gets all entities.

        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistsAsync(int id);

        //Task<bool> SaveAllAsync(); // Defined in respective class.
    }
}
