using System.Linq;
using AspNetMvcDocker.Models;

namespace AspNetMvcDocker.Interface
{
  public interface IRepository
  {
    IQueryable<Produto> Produtos { get; }
  }
}