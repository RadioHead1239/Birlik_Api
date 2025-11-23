using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_CrecerTemp
    {
        [Key]
        public int Id_VidaCrecerTemp { get; set; }


        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string Nacionalidad { get; set; }

        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaNac { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoTrabajador { get; set; }

        public decimal Sueldo { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
