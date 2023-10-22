using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Hobbies")]
    public class Hobby
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
    }
}
