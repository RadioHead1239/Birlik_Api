using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Pacifico2Detalle
{
    public int IdPacifico2Detalle { get; set; }

    public string? CodigoTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Ocupacion { get; set; }

    public string? Departamento { get; set; }

    public string? Provincia { get; set; }

    public string? Distrito { get; set; }

    public string? Direccion { get; set; }

    public string? Ruc { get; set; }

    public string? NivelRiesgo { get; set; }

    public string? MesPlanilla { get; set; }

    public string? MonedaSueldo { get; set; }

    public decimal? ImporteSueldo { get; set; }

    public string? Condicion { get; set; }

    public string? ProyObra { get; set; }

    public string? TipoProducto { get; set; }

    public string? TipoMovimiento { get; set; }

    public string? FechaInicioVigencia { get; set; }

    public string? MonedaPrima { get; set; }

    public string? CodigoAsegurado { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
