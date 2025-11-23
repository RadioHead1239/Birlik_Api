using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_FolaTemp
    {
        [Key]
        public int Id_Ramo_FolaTemp { get; set; }

        public int items { get; set; }

        public string tipo_trabajo_practicante { get; set; }

        public string profesion { get; set; }

        public decimal sueldo_practicante { get; set; }

        public string plan { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }

    }
}
