using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_PacificoTemp
    {
        [Key]
        public int Id_VidaPacificoTemp { get; set; }



        public string CodigTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string Nacionalidad { get; set; }

        public string Ocupacion { get; set; }

        public string Departamento { get; set; }

        public string Provincia { get; set; }

        public string Distrito { get; set; }

        public string Direccion { get; set; }

        public string TipoTrabajador { get; set; }

        public string Moneda { get; set; }

        public decimal ImporteSueldo { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
