using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaCrecerDetalle
    {
        [Key]
        public int Id_VidaCrecerDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }


        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string Nacionalidad { get; set; }

        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string FechaNac { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoTrabajador { get; set; }

        public decimal Sueldo { get; set; }

    }
}
