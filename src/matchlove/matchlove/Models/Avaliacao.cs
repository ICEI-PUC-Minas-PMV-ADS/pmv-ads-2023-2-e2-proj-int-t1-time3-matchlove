using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{

    [Table("Avaliacoes")]


    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        public string Comentario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a classificação")]
        public int Classificacao { get; set; }
        
        public int UsuarioId { get; set; }


}
}
