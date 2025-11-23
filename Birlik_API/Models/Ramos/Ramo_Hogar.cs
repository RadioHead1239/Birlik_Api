using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Hogar
    {
        [Key]
        public int Id_Ramo_Hogar { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string materia_asegurada { get; set; }

        public string direccion { get; set; }

        public int numero_pisos { get; set; }

        public int numero_sotanos { get; set; }

        public int anio_construccion { get; set; }

        public string uso_inmueble { get; set; }

        public decimal sumaAsegurada_inmueble { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }


    }
}
