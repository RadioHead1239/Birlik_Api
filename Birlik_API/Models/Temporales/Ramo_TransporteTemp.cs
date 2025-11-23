using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_TransporteTemp
    {
        [Key]
        public int Id_Ramo_TransporteTemp { get; set; }

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

        public string fk_usuario { get; set; }

    }
}
