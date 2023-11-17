using MarketplacePimVIII.Models;
using SeuProjeto.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MarketplacePimVIII.Models
{
    public class Carrinho
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPedido { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ValorTotal { get; set; }

        [Required(ErrorMessage = "O campo StatusPedidoId é obrigatório.")]
        public int StatusPedidoId { get; set; }

        [Required(ErrorMessage = "O campo ClienteId é obrigatório.")]
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual StatusPedido StatusPedido { get; set; }
    }
}

