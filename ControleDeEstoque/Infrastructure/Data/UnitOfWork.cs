using ControleDeEstoque.Application.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;

        public UnitOfWork(EstoqueContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
