using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Birlik.Models.Entities
{
    public class GPS
    {

        [Key]
        public int Id_GPS { get; set; }

        public DateTime FechaRegistroGPS { get; set; }

        //ANEXANDO A TABLAS
        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public string? DocumentoGPS { get; set; }

        public DateTime? VencimientoGPS { get; set; }

        public string Fk_Usuario { get; set; }

        public string? nombreEmpresaGPS { get; set; }

    }
}
