using System.Linq;
using AspNetMvcDocker.Dominio.Models;

namespace AspNetMvcDocker.Dominio.Interface
{
  public interface IRepository
  {
    IQueryable<Produto> Produtos { get; }
  }
}