using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace matchlove.Models
{
    [Table("Denuncia")]
    public class Denuncia
    {
        [Key]
        public int Id { get; set; }
        public int Denunciante { get; set; }
        public int Denunciado { get; set; }
        public int Motivo { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }

        [ForeignKey("IdConteudo")]

        public int IdConteudo { get; set; }
    }

}
