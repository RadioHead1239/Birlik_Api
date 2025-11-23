using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class RimacDetalle
    {
        [Key]
        public int Id_RimacDetalle { get; set; }

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

        public string Ruc_Cliente { get; set; }

        public string Sucursal { get; set; }

        public string Nivel_Riesgo { get; set; }

        public string Mes_Planilla { get; set; }

        public string Moneda { get; set; }

        public decimal Remuneracion { get; set; }

        public string Condicion_Trabajador { get; set; }

        public string Tipo_Producto { get; set; }

        public string Tipo_Movimient { get; set; }

        public string Fecha_InicioM { get; set; }

        public string Moneda_Prima { get; set; }

        public string Cod_AseguradoR { get; set; }

        public string Usuario { get; set; }

        public int Fk_SeguroResumen { get; set; }
        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }



    }
}
