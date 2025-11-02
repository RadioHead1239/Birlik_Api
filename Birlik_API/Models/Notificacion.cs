using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Notificacion
{
    public int IdNotificacion { get; set; }

    public DateTime? FechaNotificacion { get; set; }

    public string? TipoNotificacion { get; set; }

    public string? DescripcionNotificacion { get; set; }

    public string? Usuario { get; set; }

    public string? FkUsuario { get; set; }
}
