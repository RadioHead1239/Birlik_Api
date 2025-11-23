using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Deshonestidad
    {
        [Key]
        public int Id_Ramo_Deshonestidad { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string actividad_realizar { get; set; }

        public string ubicacion_trabajo { get; set; }

        public int nro_trabajadores { get; set; }

        public decimal sumaAsegurada { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }


    }
}
