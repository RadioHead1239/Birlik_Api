using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Punto
{
    public int IdPuntos { get; set; }

    public int? Valor { get; set; }

    public string? FkUsuario { get; set; }

    public DateTime? FechaRegistroPuntos { get; set; }

    public string? EjecutivoAsignado { get; set; }

    public string? Accion { get; set; }

    public int? FkTarea { get; set; }

    public string? TipoPunto { get; set; }

    public string? EstadoPunto { get; set; }

    public string? DescripcionPuntos { get; set; }
}
