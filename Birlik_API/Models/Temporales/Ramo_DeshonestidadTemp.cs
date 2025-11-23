using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_DeshonestidadTemp
    {
        [Key]
        public int Id_Ramo_DeshonestidadTemp { get; set; }

        public int items { get; set; }

        public string actividad_realizar { get; set; }

        public string ubicacion_trabajo { get; set; }

        public int nro_trabajadores { get; set; }

        public decimal sumaAsegurada { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }
    }
}
