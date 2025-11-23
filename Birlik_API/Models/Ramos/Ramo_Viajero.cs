using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Viajero
    {
        [Key]
        public int Id_Ramo_Viajero { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string tipo_plan { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }

        public string contacto_emergencia { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

    }
}
