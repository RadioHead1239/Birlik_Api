using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_AccidentesPersonalesTemp
    {
        [Key]
        public int Id_Ramo_AccidentesPersonalesTemp { get; set; }

        public int items { get; set; }

        public string giro_negocio { get; set; }

        public string ubicacion_riesgo { get; set; }

        public string nro_trabajadores { get; set; }

        public decimal sumaAsegurada { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }

    }
}
