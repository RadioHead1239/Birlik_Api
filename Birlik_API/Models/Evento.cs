using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public DateTime FechaInicioEvento { get; set; }

    public DateTime FechaFinEvento { get; set; }

    public string? EstadoEvento { get; set; }

    public string? Usuario { get; set; }

    public string? ArchivoEvento { get; set; }

    public string? NombreEvento { get; set; }

    public int? TrazabilidadEvento { get; set; }

    public string? TipoEvento { get; set; }

    public string? DescripcionEvento { get; set; }

    public string? Requerimientos { get; set; }

    public string? Recompensas { get; set; }
}
