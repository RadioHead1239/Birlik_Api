using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class PacificoDetalle
    {
        [Key]
        public int Id_PacificoDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }

        public int CodigoTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string Nacionalidad { get; set; }

        public string MonedaSueldo { get; set; }

        public decimal ImporteSueldo { get; set; }

        public string Observaciones { get; set; }

    }
}
