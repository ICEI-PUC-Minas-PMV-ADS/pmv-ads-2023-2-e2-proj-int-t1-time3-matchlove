using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace matchlove.Models
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int Pessoa1 { get; set; }
        public int Pessoa2 { get; set; }
        public DateTime? dataMatch { get; set; }
    }
}
