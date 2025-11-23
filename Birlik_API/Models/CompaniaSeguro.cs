using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class CompaniaSeguro
    {
        [Key]
        public int Id_CompaniaSeguro { get; set; }

        public string NombreCompaniaSeguro { get; set; }

        public string NombreCortoSeguro { get; set; }

        public string EstadoSeguro { get; set; }

        public string LogoUrl { get; set; }

        public string LogoOpacoUrl { get; set; }

        public decimal PrimaMinimaBase { get; set; }

        public string ImagenPdf { get; set; }

        public string ImagenPdfConstancia { get; set; }

        //Esto es para identificar a que ramo esta asociado la compañia de seguro si es Salud Pension o vida ley
        public int RamoExclusividad { get; set; }

        // Si - No
        // Esto es una regla para los ramos salud, pension y vida ley, que requiere generar una 1era cuota por ejemplo Pacifico asi este a Mes Vencido
        public string BotonPrimeraCuota { get; set; }

        public int TrazabilidadCompania { get; set; }

        public string? CorreosCompaniaSeguro { get; set; }

    }
}
