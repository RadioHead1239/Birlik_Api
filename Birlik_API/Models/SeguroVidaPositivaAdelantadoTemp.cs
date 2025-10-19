using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaPositivaAdelantadoTemp
{
    public int IdSeguroVidaPositivaAdelantadoTemp { get; set; }

    public int? Item { get; set; }

    public string? Nombres { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? TipoTrab { get; set; }

    public string? NroDoc { get; set; }

    public string? Sexo { get; set; }

    public string? Moneda { get; set; }

    public decimal? Remuneracion { get; set; }

    public string? Sede { get; set; }

    public string? FkUsuario { get; set; }

    public string? TipoDoc { get; set; }

    public DateOnly? FechaNac { get; set; }
}
