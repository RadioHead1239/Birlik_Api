using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Documento
{
    public int IdDocumento { get; set; }

    public string? TituloDocumento { get; set; }

    public string? RutaDocumento { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? FkPoliza { get; set; }
}
