using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_RcExtracontractual
    {
        [Key]
        public int Id_Ramo_RcExtracontractual { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

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

    }
}
