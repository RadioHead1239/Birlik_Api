using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class LaPositivaMineraDetalle
    {

        [Key]
        public int Id_LaPositivaMineraDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }

        public string numero { get; set; }

        public string razonSocial { get; set; }

        public string RUC { get; set; }

        public string unidadMinera { get; set; }

        public string dni { get; set; }

        public string apellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public string nombres { get; set; }

        public string puestoTrabajo { get; set; }

        public string fechaNacimiento { get; set; }

        public string categoria { get; set; }

        public string clinica { get; set; }

        public decimal remuneracion { get; set; }


    }
}
