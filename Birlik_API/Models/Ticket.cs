using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Ticket
{
    public int IdTicket { get; set; }

    public string? TipoTicket { get; set; }

    public string? EstadoTicket { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? ImagenTicket { get; set; }

    public string? AsignadoA { get; set; }

    public string? DescripcionTicket { get; set; }

    public string? RespuestaTicket { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkCliente { get; set; }

    public string? FkResponsable { get; set; }

    public string? FkPolizas { get; set; }

    public string? FkCuotas { get; set; }

    public string? TrabajadorDni { get; set; }

    public decimal? ValorTicket { get; set; }

    public string? TextoTicket { get; set; }

    public string? GeneracionTicket { get; set; }

    public DateTime? FechaModificable1 { get; set; }

    public DateTime? FechaModificable2 { get; set; }

    public DateTime? FechaModificable3 { get; set; }
}
