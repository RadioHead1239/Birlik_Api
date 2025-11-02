using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class PacificoEpsDetalle
{
    public int IdPacificoEpsDetalle { get; set; }

    public int? CodigoTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombre { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? MonedaSueldo { get; set; }

    public int? NumeroDependiente { get; set; }

    public string? Plan { get; set; }

    public decimal? Tarifa { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
