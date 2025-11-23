using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_RcMaptel
    {
        [Key]
        public int Id_Ramo_RcMaptel { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }
        public string departamento_Peru { get; set; }
        public string ubicacion_riesgo { get; set; }
        public string tipo_trabajo { get; set; }
        public string descripcion_actividadProyecto { get; set; }
        public string asegurado_adicional { get; set; }
        public decimal monto_contratado { get; set; }
        public decimal sumaAsegurada { get; set; }
        public decimal tasaRiesgo { get; set; }
        public decimal pn { get; set; }
        public decimal pc { get; set; }
        public decimal pt { get; set; }
        public decimal comision { get; set; }
        public decimal montoComision { get; set; }
        public string siniestralidad { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string nro_de_motor { get; set; }
        public string nro_Serie { get; set; }
        public string color { get; set; }
        public int nro_asiento { get; set; }
        public string gas { get; set; }
        public int fabricacion { get; set; }
        public decimal uit_asegurada { get; set; }




    }
}
