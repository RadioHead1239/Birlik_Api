using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Observacion
{
    public int IdObservacion { get; set; }

    public string? Categoria { get; set; }

    public int? FkGlobal { get; set; }

    public string? Tipo { get; set; }

    public string? FkUsuario { get; set; }

    public DateTime? FechaObservacion { get; set; }

    public string? Comentario { get; set; }
}
