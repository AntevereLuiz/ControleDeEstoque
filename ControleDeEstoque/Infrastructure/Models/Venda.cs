using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infrastructure
{
    public class Venda
    {
        public Guid Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produto { get; set; }
        public DateTime DataDaVenda { get; set; }
    }
}
