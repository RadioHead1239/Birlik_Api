using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaMapfreDetalle
    {
        [Key]
        public int Id_VidaMapfreDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }


        public string TipDoc { get; set; }

        public string NumDoc { get; set; }

        public string ApePaterno { get; set; }

        public string ApeMaterno { get; set; }

        public string Nombres { get; set; }

        public string NombreCompleto { get; set; }

        public string Nacimiento { get; set; }

        public decimal Sueldo { get; set; }

        public string Ocupacion { get; set; }

        public string TipRiesgo { get; set; }


    }
}
