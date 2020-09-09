using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infrastructure
{
    public class Estoque
    {
        public Guid Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
