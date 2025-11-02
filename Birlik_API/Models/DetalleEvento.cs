using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class DetalleEvento
{
    public int IdDetalleEvento { get; set; }

    public DateTime? FechaConfirmacion { get; set; }

    public string? FkUsuario { get; set; }

    public string? RespuestaEvento { get; set; }

    public int? FkEvento { get; set; }
}
