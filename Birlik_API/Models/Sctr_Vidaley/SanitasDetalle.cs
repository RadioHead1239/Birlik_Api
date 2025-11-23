using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class SanitasDetalle
    {
        [Key]
        public int Id_SanitasDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }

        public string Nombres { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string TipoTrabajador { get; set; }

        public string PaisNacimiento { get; set; }

        public string TipoIdent { get; set; }

        public string NumIdent { get; set; }

        public string Sexo { get; set; }

        public string FecNacimiento { get; set; }

        public string Moneda { get; set; }

        public decimal Remuneracion { get; set; }

        public string EstadoCivil { get; set; }

        public string Sede { get; set; }



    }
}
