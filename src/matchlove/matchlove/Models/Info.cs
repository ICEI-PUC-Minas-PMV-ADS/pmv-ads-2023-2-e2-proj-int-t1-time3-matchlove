using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using matchlove.Enum;
namespace matchlove.Models
{
    [Table("Infos")]
    public class Info   
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PessoaId")]
        public int PessoaId { get; set; }
        public TipoInfo TipoInfo { get; set; }
        public string Descricao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
