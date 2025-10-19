using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class PacificoDetalle
{
    public int IdPacificoDetalle { get; set; }

    public int? CodigoTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? Nacionalidad { get; set; }

    public string? MonedaSueldo { get; set; }

    public decimal? ImporteSueldo { get; set; }

    public string? Observaciones { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
