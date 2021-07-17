namespace AspNetMvcDocker.Dominio.Models
{
  public class Produto
  {
    public Produto(string nome = null, string categoria = null, decimal preco = 0)
    {
      this.Nome = nome;
      this.Categoria = categoria;
      this.Preco = preco;
    }

    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public decimal Preco { get; set; }
  }
}