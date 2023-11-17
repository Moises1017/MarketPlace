using MarketplacePimVIII.Models;
using SeuProjeto.Models;
using System.ComponentModel.DataAnnotations;

namespace MarketplacePimVIII.Models
{
    public class ItemCarrinho
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
        public int Quantidade { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "O campo CarrinhoId é obrigatório.")]
        public int CarrinhoId { get; set; }

        [Required(ErrorMessage = "O campo ProdutoId é obrigatório.")]
        public int ProdutoId { get; set; }

        public virtual Carrinho Carrinho { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
