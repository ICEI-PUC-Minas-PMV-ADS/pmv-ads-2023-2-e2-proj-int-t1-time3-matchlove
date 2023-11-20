using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using matchlove.Enum;
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
        public TipoGeneros Genero { get; set; }
        [Required(ErrorMessage = "A orientação sexual é obrigatório!")]
        public TipoDescobertas OrientacaoSexual { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        public DateTime? DataNascimento { get; set; }
        public string FotoPerfil {  get; set; }
        
        //public Login Login { get; set; }
        public virtual ICollection<Denuncia> DenunciasRecebidas { get; set; }
        public virtual ICollection<Denuncia> DenunciasFeitas { get; set; }
        //[Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail valido")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Obrigatório informar senha!")]
        //[DataType(DataType.Password)]
        //public string Senha { get; set; }

        //[Required(ErrorMessage = "Obrigatório Telefone")]
        //public int Telefone { get; set; }

        //[Required(ErrorMessage = "Obrigatório Cadastrar Perfil")]
        //public TipoPerfils Perfil { get; set; }
        // Propriedade de navegação para Infos
        public virtual ICollection<Info> Infos { get; set; }

    }

}   
