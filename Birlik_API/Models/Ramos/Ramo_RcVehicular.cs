using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_RcVehicular
    {
        [Key]
        public int Id_Ramo_RcVehicular { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }
        public string departamento_peru { get; set; }
        public string uso { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string nro_motor { get; set; }
        public string nro_serie { get; set; }
        public string color { get; set; }
        public string nro_asiento { get; set; }
        public string gas { get; set; }
        public int fabricacion { get; set; }
        public string endosatario { get; set; }
        public decimal sumaAseguradaRC { get; set; }
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
