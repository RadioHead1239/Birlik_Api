using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Notum
{
    public int IdNota { get; set; }

    public string? TipoNota { get; set; }

    public string? DescripcionNota { get; set; }

    public DateTime? FechaRegistroNota { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkCuota { get; set; }

    public DateTime? FechaRecordatorio { get; set; }

    public int? FkClienteNota { get; set; }
}
