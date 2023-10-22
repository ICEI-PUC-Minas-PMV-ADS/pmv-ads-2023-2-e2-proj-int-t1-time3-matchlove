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
        [ForeignKey("FilmeId")]
        public int? FilmeId { get; set; }
        [ForeignKey("MusicaId")]
        public int? MusicaId { get; set; }
        [ForeignKey("HobbyId")]
        public int? HobbyId { get; set; }
        public string? Descricao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Filme Filme { get; set; }
        public virtual Musica Musica { get; set; }
        public virtual Hobby Hobby { get; set; }
    }
}
