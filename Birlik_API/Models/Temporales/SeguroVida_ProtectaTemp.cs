using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_ProtectaTemp
    {
        [Key]
        public int Id_VidaProtectaTemp { get; set; }


        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApelidoMaterno { get; set; }

        public string Nombres { get; set; }

        public string Sexo { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaNac { get; set; }

        public string TipoTrabajador { get; set; }

        public decimal SueldoBruto { get; set; }

        public string CorreoElectronico { get; set; }

        public string Celular { get; set; }

        public string Sede { get; set; }

        public string TipoMovimiento { get; set; }

        public string PaisNacimiento { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
