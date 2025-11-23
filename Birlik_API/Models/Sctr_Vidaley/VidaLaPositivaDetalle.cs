using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaLaPositivaDetalle
    {
        [Key]
        public int Id_VidaLaPositivaDetalle { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int Fk_cliente { get; set; }

        public int Fk_poliza { get; set; }


        public string Nombres { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string TipoTrab { get; set; }

        public string TipoDoc { get; set; }

        public string NroDoc { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string FechaNac { get; set; }

        public string Correo { get; set; }

        public string Moneda { get; set; }

        public decimal Sueldo { get; set; }

        public string FechaIngreso { get; set; }


    }
}
