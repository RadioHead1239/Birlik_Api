using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Soat
    {
        [Key]
        public int Id_Ramo_Soat { get; set; }
        public int items { get; set; }
        public string departamento_Peru { get; set; }
        public string uso { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string nro_de_motor { get; set; }
        public string nro_Serie { get; set; }
        public string color { get; set; }
        public int nro_asiento { get; set; }
        public int fabricacion { get; set; }
        public decimal pn { get; set; }
        public decimal pc { get; set; }
        public decimal pt { get; set; }
        public decimal comision { get; set; }
        public decimal montoComision { get; set; }
        public string siniestralidad { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }
    }
}
