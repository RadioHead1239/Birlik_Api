using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_PositivaAdelantadoTemp
    {
        [Key]
        public int Id_SeguroVida_PositivaAdelantadoTemp { get; set; }

        public string Nombres { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string TipoTrab { get; set; }

        public string TipoDoc { get; set; }

        public string NroDoc { get; set; }

        public string Sexo { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaNac { get; set; }

        public string Moneda { get; set; }

        public decimal Remuneracion { get; set; }

        public string Sede { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
