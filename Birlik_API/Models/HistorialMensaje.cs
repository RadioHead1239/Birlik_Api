using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class HistorialMensaje
{
    public int IdHistorialMensaje { get; set; }

    public string? TipoHistorialMensaje { get; set; }

    public DateTime? FechaRegistroHistorialMensaje { get; set; }

    public int? FkCliente { get; set; }

    public string? Usuario { get; set; }

    public int? FkMensajeEnviado { get; set; }

    public int? FkDetalleUsuario { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkCuota { get; set; }
}
