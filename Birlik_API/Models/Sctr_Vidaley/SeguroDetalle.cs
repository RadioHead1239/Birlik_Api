using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class SeguroDetalle
    {
        [Key]
        public int Id_SeguroDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Nombres { get; set; }

        public string NombresCompletos { get; set; }

        public decimal Sueldo { get; set; }

        public string TipoSeguro { get; set; }

        public string? TipoTrabajador { get; set; }

        public string? EstadoTrabajador { get; set; }

        public DateTime? FechaRetiro { get; set; }

    }
}
