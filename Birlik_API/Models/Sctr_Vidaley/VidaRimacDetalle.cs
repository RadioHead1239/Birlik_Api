using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaRimacDetalle
    {
        [Key]
        public int Id_VidaRimacDetalle { get; set; }

        public string TipoDoc { get; set; }

        public string NroDoc { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string FechaNac { get; set; }

        public string Sexo { get; set; }

        public string Departamento { get; set; }

        public string Provincia { get; set; }

        public string Distrito { get; set; }

        public string Direccion { get; set; }

        public string RucCliente { get; set; }

        public string Sucursal { get; set; }

        public string NivelRiesgo { get; set; }

        public string MesPlanilla { get; set; }

        public string Moneda { get; set; }

        public decimal Sueldo { get; set; }

        public string Condicion_Trabajador { get; set; }

        public string TipoProducto { get; set; }

        public string TipoMovimiento { get; set; }

        public string FechaInicioMovimiento { get; set; }

        public string MonedaPrima { get; set; }

        public string Cod_AseguradoRimac { get; set; }

        public string Usuario { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }



    }
}
