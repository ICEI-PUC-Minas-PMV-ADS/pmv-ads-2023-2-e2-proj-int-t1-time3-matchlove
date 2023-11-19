using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace matchlove.Models
{
    [Table("Denuncias")]
    public class Denuncia
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PerfilDenunciado")]
        public int PerfilDenunciadoId { get; set; }
        public Pessoa PerfilDenunciado { get; set; }

        [ForeignKey("Denunciante")]
        public int DenuncianteId { get; set; }
        public Pessoa Denunciante { get; set; }

        public StatusDenuncia Status { get; set; }

        public enum StatusDenuncia
        {
            NaoLida,
            Procedente,
            Improcedente
        }
    }
}