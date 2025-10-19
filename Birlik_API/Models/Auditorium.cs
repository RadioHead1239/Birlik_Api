using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Auditorium
{
    public int Id { get; set; }

    public string? TablaAfectada { get; set; }

    public string? Operacion { get; set; }

    public DateTime? FechaHora { get; set; }

    public string? UsuarioInsercion { get; set; }

    public string? NombreTrigger { get; set; }

    public int? RegistroId { get; set; }

    public string? ValoresAnteriores { get; set; }

    public string? ValoresNuevos { get; set; }

    public string? ComandoSql { get; set; }

    public string? NombreHost { get; set; }

    public string? NombreAplicacion { get; set; }

    public string? DireccionIp { get; set; }

    public int? Spid { get; set; }
}
