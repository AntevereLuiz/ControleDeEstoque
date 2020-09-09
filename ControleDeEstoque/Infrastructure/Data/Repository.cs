using ControleDeEstoque.Application.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EstoqueContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(EstoqueContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<T> FindById(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).AsQueryable();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
