using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Transporte
    {
        [Key]
        public int Id_Ramo_Transporte { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string radio_accion { get; set; }

        public string tipo_mercaderia { get; set; }

        public string lme { get; set; }

        public string lea { get; set; }

        public decimal sumaAsegurada { get; set; }

        public decimal tasa_riesgo { get; set; }
        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }



    }
}
