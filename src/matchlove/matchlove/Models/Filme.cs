using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
    }
}
