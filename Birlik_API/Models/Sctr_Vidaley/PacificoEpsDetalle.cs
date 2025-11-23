using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class PacificoEpsDetalle
    {
        [Key]
        public int Id_PacificoEpsDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }

        public int NumeroDependiente { get; set; }

        public int CodigoTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Nombre { get; set; }

        public string FechaNacimiento { get; set; }

        public string MonedaSueldo { get; set; }

        public decimal Tarifa { get; set; }

        public string Plan { get; set; }

    }
}
