using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_RoboAsaltoTemp
    {
        [Key]
        public int Id_Ramo_RoboAsaltoTemp { get; set; }

        public int items { get; set; }

        public string caracteristicas_riesgo { get; set; }

        public string giro_negocio { get; set; }

        public string materia_asegurada { get; set; }

        public decimal valor_declarado { get; set; }

        public decimal valor_asegurado { get; set; }

        public int nro_locales_asegurado { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }
    }
}
