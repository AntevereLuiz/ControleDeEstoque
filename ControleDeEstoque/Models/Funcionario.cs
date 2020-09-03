using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}