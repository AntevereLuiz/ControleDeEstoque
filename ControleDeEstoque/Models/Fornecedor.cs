using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}