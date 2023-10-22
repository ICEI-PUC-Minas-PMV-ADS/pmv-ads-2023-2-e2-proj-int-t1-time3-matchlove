using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Musicas")]
    public class Musica
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public string artista { get; set; }
    }
}
