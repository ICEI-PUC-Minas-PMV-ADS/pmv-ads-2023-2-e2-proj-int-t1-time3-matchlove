using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Curtidas")]
    public class Curtida
    {
        [Key]
        public int Id { get; set; }
        public int IdRemetente { get; set; }
        public int IdDestinatario { get; set; }
        public bool DeuMatch { get; set; }
    }
}
