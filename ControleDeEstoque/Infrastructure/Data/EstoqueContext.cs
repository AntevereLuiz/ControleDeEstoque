using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Infrastructure.Data
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(DbContextOptions<EstoqueContext> options)
           : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UsuarioRole> UsuariosRoles { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Password=SenhaSQL)(*;Persist Security Info=True;User ID=sa;Initial Catalog=DBEstoque;Data Source=127.0.0.1,1433");
        //}
    }
}
