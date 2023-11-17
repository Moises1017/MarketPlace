namespace MarketplacePimVIII.Models
{ public class Produto
{

    public int Id { get; set; }

    public string Descricao { get; set; }

    public decimal Preco { get; set; }

    public string Imagem { get; set; }

    public bool Status { get; set; }

    public int VendedorId { get; set; }
    public int CategoriaId { get; set; }

    public virtual Vendedor Vendedor { get; set; }
    public virtual Categoria Categoria { get; set; }
}
}
