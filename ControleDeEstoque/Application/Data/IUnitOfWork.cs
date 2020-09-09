using System;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
