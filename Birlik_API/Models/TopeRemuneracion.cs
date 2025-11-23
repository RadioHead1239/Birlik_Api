using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class TopeRemuneracion
    {
        [Key]
        public int Id_TopeRemuneracion { get; set; }

        public decimal SueldoTope { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaInicioVigencia { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaFinVigencia { get; set; }

        public string EstadoTopeRemuneracion { get; set; }


    }
}
