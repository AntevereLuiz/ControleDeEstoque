using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleDeEstoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        [HttpGet]
        public List<Produto> GetProdutos()
        {
            var produtos = new List<Produto>();

            return produtos;

        }
    }
}
