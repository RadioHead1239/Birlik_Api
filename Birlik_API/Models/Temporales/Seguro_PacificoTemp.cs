using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Seguro_PacificoTemp
    {
        [Key]
        public int Id_PacificoTemp { get; set; }


        public int CodigoTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string Nacionalidad { get; set; }

        public string MonedaSueldo { get; set; }

        public decimal ImporteSueldo { get; set; }

        public string Observaciones { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
