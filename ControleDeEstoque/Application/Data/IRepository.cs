using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        IQueryable<T> FindById(Expression<Func<T, bool>> expression);
        IQueryable<T> FindAll();
        Task<bool> Any(Expression<Func<T, bool>> expression);
    }
}
