using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório!")]
        public int Genero { get; set; }
        [Required(ErrorMessage = "A orientação sexual é obrigatório!")]
        public int OrientacaoSexual { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Telefone")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório Cadastrar Perfil")]
        public Perfil Perfil { get; set; }
     }
    public enum Perfil
    {
        Admin,
        User

    }
}   
