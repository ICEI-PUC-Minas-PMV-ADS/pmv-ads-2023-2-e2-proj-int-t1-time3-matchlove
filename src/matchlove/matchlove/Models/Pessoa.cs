using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório!")]
        public int Genero { get; set; }
        [Required(ErrorMessage = "A orientação sexual é obrigatório!")]
        public int OrientacaoSexual { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        public DateTime? DataNascimento { get; set; }
     }
}
