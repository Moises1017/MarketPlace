namespace MarketplacePimVIII.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Razão Social é obrigatório.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O campo Nome Fantasia é obrigatório.")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 25 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        [StringLength(18, MinimumLength = 14, ErrorMessage = "O CNPJ deve ter entre 14 e 18 caracteres.")]
        public string CNPJ { get; set; }

        public int Comissao { get; set; }
        public int EnderecoId { get; set; }

        public virtual Endereco Endereco { get; set; }
    }

}