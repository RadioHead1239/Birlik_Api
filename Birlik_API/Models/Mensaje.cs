using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Mensaje
{
    public int IdMensaje { get; set; }

    public DateTime? FechaMensaje { get; set; }

    public string? EstadoMensaje { get; set; }

    public string? Usuario { get; set; }

    public string? FkUsuario { get; set; }

    public DateTime? FechaLeido { get; set; }

    public string? NombreMensaje { get; set; }

    public int? TrazabilidadMensaje { get; set; }

    public string? ArchivoInformativo { get; set; }

    public string? DescripcionMensaje { get; set; }
}
