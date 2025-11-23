using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class PersonalCompaniaSeguro
    {

        [Key]
        public int Id_PersonalCompaniaSeguro { get; set; }

        public string? Fk_CompaniasSeguros { get; set; }

        public string? NombrePersonal { get; set; }

        public string? ApellidoPaternoPersonal { get; set; }

        public string? SexoPersonal { get; set; }

        public string? CorreoPersonal { get; set; }

        public string? CelularPersonal { get; set; }

        public string? CargoPersonal { get; set; }
    }
}
