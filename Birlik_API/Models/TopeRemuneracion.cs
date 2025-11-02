using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class TopeRemuneracion
{
    public int IdTopeRemuneracion { get; set; }

    public decimal? SueldoTope { get; set; }

    public DateOnly? FechaInicioVigencia { get; set; }

    public DateOnly? FechaFinVigencia { get; set; }

    public string? EstadoTopeRemuneracion { get; set; }
}
