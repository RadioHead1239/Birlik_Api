using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_RcProfesionalTemp
    {
        [Key]
        public int Id_Ramo_RcProfesionalTemp { get; set; }


        public int items { get; set; }

        public string caracteristicas_riesgo { get; set; }

        public string ubicacion { get; set; }

        public string giro_negocio { get; set; }

        public decimal valorAsegurado { get; set; }

        public decimal sumaAsegurada { get; set; }

        public decimal tasa_riesgo { get; set; }
        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }


    }
}
