using System.ComponentModel.DataAnnotations;

namespace Birlik.Models
{
    public class CompaniaGPS
    {

        [Key]
        public int Id_Compania_GPS { get; set; }

        public int Fk_Organizacion { get; set; }

        public string? NombreCompaniaGPS { get; set; }

        public string? NombreCortoCompaniaGPS { get; set; }

    }
}
