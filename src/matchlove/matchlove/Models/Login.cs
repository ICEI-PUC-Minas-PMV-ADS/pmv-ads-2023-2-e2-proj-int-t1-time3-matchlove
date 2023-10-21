using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar senha")]
        public string Senha { get; set; }

        [Display(Name = "Pessoa")]
        [Required(ErrorMessage = "Obrigatório informar Id da Pessoa")]
        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        public Pessoa Pessoa { get; set; }

    }
}
