
using System.ComponentModel.DataAnnotations;

namespace MarketplacePimVIII.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo EndereçoID é obrigatório.")]
        public int EnderecoID { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
