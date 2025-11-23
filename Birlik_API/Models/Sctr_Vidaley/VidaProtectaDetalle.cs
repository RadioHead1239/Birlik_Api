using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaProtectaDetalle
    {
        [Key]
        public int Id_VidaProtectaDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }


        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApelidoMaterno { get; set; }

        public string Nombres { get; set; }

        public string Sexo { get; set; }

        public string FechaNac { get; set; }

        public string TipoTrabajador { get; set; }

        public decimal SueldoBruto { get; set; }

        public string CorreoElectronico { get; set; }

        public string Celular { get; set; }

        public string Sede { get; set; }

        public string TipoMovimiento { get; set; }

        public string PaisNacimiento { get; set; }



    }
}
