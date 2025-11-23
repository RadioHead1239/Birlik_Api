using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Seguro_MapfreTemp
    {
        [Key]
        public int Id_Seguro_MapfreTemp { get; set; }
        public string tipDoc { get; set; }
        public string numDoc { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string nombres { get; set; }
        public string nombre_Completo { get; set; }
        public string nacimiento { get; set; }
        public decimal sueldo { get; set; }
        public string fk_usuario { get; set; }

        public int Item { get; set; }

    }
}
