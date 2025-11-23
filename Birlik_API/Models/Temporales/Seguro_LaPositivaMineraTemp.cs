using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Seguro_LaPositivaMineraTemp
    {
        [Key]
        public int Id_LaPositivaMineraTemp { get; set; }

        public string numero { get; set; }

        public string razonSocial { get; set; }

        public string RUC { get; set; }

        public string unidadMinera { get; set; }

        public string dni { get; set; }

        public string apellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public string nombres { get; set; }

        public string puestoTrabajo { get; set; }

        public string fechaNacimiento { get; set; }

        public string categoria { get; set; }

        public string clinica { get; set; }

        public decimal remuneracion { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }

    }
}
