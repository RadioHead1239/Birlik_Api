using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaPacificoDetalle
    {
        [Key]
        public int Id_VidaPacificoDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }


        public string CodigTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string FechaNacimiento { get; set; }

        public string Nacionalidad { get; set; }

        public string Sexo { get; set; }
        public string Ocupacion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string TipoTrabajador { get; set; }
        public string Moneda { get; set; }

        public decimal ImporteSueldo { get; set; }


    }
}
