using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaChubbTemp
{
    public int IdSeguroVidaTemp { get; set; }

    public string? Movimiento { get; set; }

    public string? ApePaterno { get; set; }

    public string? ApeMaterno { get; set; }

    public string? Pnombre { get; set; }

    public string? Snombre { get; set; }

    public string? TipoDoc { get; set; }

    public string? NroDoc { get; set; }

    public string? Genero { get; set; }

    public string? FecNac { get; set; }

    public decimal? Remuneracion { get; set; }

    public string? FkUsuario { get; set; }

    public int? Item { get; set; }
}
