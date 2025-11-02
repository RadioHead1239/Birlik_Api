using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class MensajeEnviado
{
    public int IdMensajeEnviado { get; set; }

    public string GeneradoMensajeEnviado { get; set; } = null!;

    public string? DescripcionMensajeEnviado { get; set; }

    public string? AsuntoMensajeEnviado { get; set; }

    public string? ParaMensajeEnviado { get; set; }

    public DateTime FechaRegistroMensajeEnviado { get; set; }

    public string? EstadoMensaje { get; set; }

    public DateTime? FechaProgramada { get; set; }

    public string? ImagenMensaje { get; set; }

    public string? Archivo1Mensaje { get; set; }

    public string? Archivo2Mensaje { get; set; }

    public string? Archivo3Mensaje { get; set; }

    public string? Archivo4Mensaje { get; set; }

    public string? CopiaMensajeEnviado { get; set; }

    public string? ArchivoVisualizar { get; set; }

    public int? FkCliente { get; set; }
}
