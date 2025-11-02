using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Registro
{
    public int IdRegistro { get; set; }

    public string? DescripcionRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public string? TipoRegistro { get; set; }

    public string? FkUsuario { get; set; }

    public string? Estado { get; set; }

    public int? FkCuota { get; set; }
}
