using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Compra
    {
        public Guid Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<Produto> Produto { get; set; }
        public DateTime DataDaCompra { get; set; }
    }
}
