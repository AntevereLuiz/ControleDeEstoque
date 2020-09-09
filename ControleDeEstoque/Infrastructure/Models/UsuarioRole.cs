using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infrastructure
{
    public class UsuarioRole
    {
        public Guid Id { get; set; }
        public Funcionario Funcionario{ get; set; }
        public Role Role { get; set; }
    }
}
