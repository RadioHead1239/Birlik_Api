using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Tarea
{
    public int IdTarea { get; set; }

    public string? EstadoTarea { get; set; }

    public DateTime? FechaRegistroTarea { get; set; }

    public string? FkUsuario { get; set; }

    public string? Usuario { get; set; }

    public string? ArchivoTarea { get; set; }

    public string? DescripcionTarea { get; set; }

    public string? ArchivoTarea1 { get; set; }

    public string? ArchivoTarea2 { get; set; }

    public string? ArchivoTarea3 { get; set; }

    public string? ArchivoTarea4 { get; set; }

    public string? ArchivoTarea5 { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? Respuesta { get; set; }

    public string? EjecutivoApoyo { get; set; }
}
