using Birlik.Models.Entities;
using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class HistorialCartaNombramiento
{
    public int IdCartaNombramiento { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkCliente { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? UrlArchivo { get; set; }

    public virtual Cliente? FkClienteNavigation { get; set; }
}
