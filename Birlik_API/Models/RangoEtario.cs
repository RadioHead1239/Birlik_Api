using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RangoEtario
{
    public int IdRangoEtario { get; set; }

    public string? TipoRangoEtario { get; set; }

    public int? Valor1 { get; set; }

    public int? Valor2 { get; set; }

    public int? FkPoliza { get; set; }

    public decimal? TasaRangoEtario { get; set; }

    public string? Texto { get; set; }
}
