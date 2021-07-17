using System.Linq;
using AspNetMvcDocker.Interface;
using AspNetMvcDocker.Models;

namespace AspNetMvcDocker.Repository
{
  public class TesteRepository : IRepository
  {
    private static Produto[] Dados = new Produto[]{
        new Produto { ProdutoId = 1, Nome = "Caneta", Categoria = "Escolar", Preco = 100},
        new Produto { ProdutoId = 2, Nome = "Borracha", Categoria = "Escolar", Preco = 200},
        new Produto { ProdutoId = 3, Nome = "Caderno", Categoria = "Escolar", Preco = 300},
        new Produto { ProdutoId = 4, Nome = "Tablet", Categoria = "Eletrônicos", Preco = 400},
        new Produto { ProdutoId = 5, Nome = "IPhone", Categoria = "Eletrônicos", Preco = 500}
    };
    public IQueryable<Produto> Produtos
      => Dados.AsQueryable();
  }
}