using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque
{
    public class Produto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}