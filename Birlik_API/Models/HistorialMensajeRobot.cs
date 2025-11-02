using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class HistorialMensajeRobot
{
    public int IdHistorialMensajeRobot { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkCliente { get; set; }

    public string? TipoMensaje { get; set; }

    public DateOnly? FechaEnvio { get; set; }

    public DateOnly? FechaSiguienteEnvio { get; set; }

    public string? Estado { get; set; }

    public string? RespuestaCliente { get; set; }

    public string? UsuarioAprobador { get; set; }

    public string? Observaciones { get; set; }
}
