using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Seguro_CrecerTemp
    {
        [Key]
        public int Id_CrecerTemp { get; set; }

        public string Nombres { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string TipoTrabajador { get; set; }

        public string PaisNacimiento { get; set; }

        public string TipoIdent { get; set; }

        public string NumIdent { get; set; }

        public string Sexo { get; set; }

        public string FecNacimiento { get; set; }

        public string Moneda { get; set; }

        public decimal Remuneracion { get; set; }

        public string EstadoCivil { get; set; }

        public string Sede { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
