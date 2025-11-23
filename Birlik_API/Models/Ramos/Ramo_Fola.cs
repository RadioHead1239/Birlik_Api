using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Fola
    {
        [Key]
        public int Id_Ramo_Fola { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string tipo_trabajo_practicante { get; set; }

        public string profesion { get; set; }

        public decimal sueldo_practicante { get; set; }

        public string plan { get; set; }

        public decimal  pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

    }
}
