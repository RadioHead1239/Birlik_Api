using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_MapfreTemp
    {
        [Key]
        public int Id_VidaMapfreTemp { get; set; }



        public string TipDoc { get; set; }

        public string NumDoc { get; set; }

        public string ApePaterno { get; set; }

        public string ApeMaterno { get; set; }

        public string Nombres { get; set; }

        public string NombreCompleto { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime Nacimiento { get; set; }

        public decimal Sueldo { get; set; }

        public string Ocupacion { get; set; }

        public string TipRiesgo { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
