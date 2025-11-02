using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Adjunto
{
    public int Id { get; set; }

    public int? CorreoId { get; set; }

    public string? Nombre { get; set; }

    public int? Tamaño { get; set; }

    public string? LinkDescarga { get; set; }

    public virtual HistorialCorreo? Correo { get; set; }
}
