using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_DubaiTemp
    {

        [Key]
        public int Id_Ramo_DubaiTemp { get; set; }

        public int items { get; set; }
        public string tipoCalle { get; set; }
        public string NombreCalle { get; set; }
        public int Numero { get; set; }
        public string TipoInterior { get; set; }
        public string Interior { get; set; }
        public string Mz { get; set; }
        public string Lote { get; set; }
        public string KM { get; set; }
        public string TipoConjuntoHabitacional { get; set; }
        public string NombreConjuntoHabitacional { get; set; }
        public string SubdivisionConjuntoHabitacional { get; set; }
        public string NombreSubdivisionConjuntoHabitacional { get; set; }
        public string Referencia { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public decimal Ubigeo { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string RegistroValido1 { get; set; }
        public int AnioConstruccionEdificacion { get; set; }
        public int AnioReforzamientoEstructural { get; set; }
        public string TipoMaterialConstruccionPredominante { get; set; }
        public string TipoEstructuraEspecial { get; set; }

        public string NumeroPisoEdificacion { get; set; }

        public string NumeroSotanosEdificacion { get; set; }

        public string TipoBienAsegurado { get; set; }

        public string TipoUso { get; set; }

        public string GiroInmueble { get; set; }

        public string CodCIIU { get; set; }
        public string DescripcionCIIU { get; set; }
        public string RegistroValido2 { get; set; }
        public decimal Edificacion { get; set; }

        public decimal ValorEdificacion { get; set; }

        public decimal TotalEdificacion { get; set; }

        public decimal Existencias { get; set; }

        public decimal EquiposElectronicos { get; set; }

        public decimal MaquinariaFija { get; set; }

        public decimal MaquinariaMovilEquipos { get; set; }

        public decimal ContenidoGeneral { get; set; }

        public decimal SeleccionarValorContenido { get; set; }

        public decimal GastosEstables { get; set; }
        public decimal TotalContenido { get; set; }

        public string PeriodoCorrespondienteValorDeclarado { get; set; }

        public decimal TotalLucroCesante { get; set; }

        public decimal ValorDeclaradoTotal { get; set; }

        public string RegistroValidoVD { get; set; }

        public string ObservacionesAdicionales { get; set; }

        public string fk_usuario { get; set; }

    }
}
