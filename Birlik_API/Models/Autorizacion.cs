using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Autorizacion
{
    public int IdAutorizacion { get; set; }

    public string? TipoAutorizacion { get; set; }

    public int? FkPoliza { get; set; }

    public string? EstadoAutorizacion { get; set; }

    public DateOnly? FechaAutorizacion { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkCliente { get; set; }

    public int? FkCuota { get; set; }
}
