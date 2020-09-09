using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Infrastructure
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Venda> Vendas { get; set; }

    }
}