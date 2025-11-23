using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_RcExtracontractualTemp
    {
        [Key]
        public int Id_Ramo_RcExtracontractualTemp { get; set; }

        public int items { get; set; }
        public string departamento_peru { get; set; }

        public string ubicacionRiesgo { get; set; }

        public string tipoTrabajo { get; set; }

        public string descripcion_ActividadProyecto { get; set; }

        public string asegurado_Adicional { get; set; }

        public decimal montoContratado { get; set; }
        public decimal sumaAsegurada { get; set; }
        public decimal tasaRiesgo { get; set; }
        public decimal pn { get; set; }
        public decimal pc { get; set; }
        public decimal pt { get; set; }
        public decimal comision { get; set; }
        public decimal montoComision { get; set; }
        public string siniestralidad { get; set; }

        public string fk_usuario { get; set; }


    }
}
