using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroPacificoEpsTemp
{
    public int IdPacificoEpsTemp { get; set; }

    public int? CodigoTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombre { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? MonedaSueldo { get; set; }

    public int? NumeroDependiente { get; set; }

    public string? Plan { get; set; }

    public decimal? Tarifa { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }
}
