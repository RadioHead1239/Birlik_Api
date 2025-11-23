using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Flotante
    {

        [Key]
        public int Id_Ramo_Flotante { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string asegurado { get; set; }

        public string fechaSalida_origen { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }

        public string descripcionMercaderia_transportar { get; set; }

        public string tipo_embalaje { get; set; }

        public decimal tasa { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

    }
}
