using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string TipoPersona { get; set; } = null!;

    public string? NombreTipoPersona { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Direccion { get; set; }

    public string? Distrito { get; set; }

    public string? Ciudad { get; set; }

    public string? Provincia { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Email { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Profesion { get; set; }

    public DateOnly? VencimientoLicenciaConducir { get; set; }

    public string? Referencia { get; set; }

    public string? CartaNombramiento { get; set; }

    public string? Nombres { get; set; }

    public string? EmailContacto { get; set; }

    public string? Celular { get; set; }

    public string? Observacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string? FkUsuario { get; set; }

    public string? Notificacion { get; set; }

    public string? Imagen { get; set; }

    public DateOnly? FechaMaximoFinPoliza { get; set; }

    public int? NumeroPolizas { get; set; }

    public int? FkSubagente { get; set; }

    public int? FkGrupoEconomico { get; set; }

    public int? FkGiroNegocio { get; set; }

    public DateTime FechaAntiguedad { get; set; }

    public string? EjecutivoResponsable { get; set; }

    public string? EstadoCliente { get; set; }

    public string? EjecutivoProvisional { get; set; }

    public bool? FacturaXml { get; set; }

    public int? Grupo { get; set; }

    public string? DniDocumento { get; set; }

    public virtual ICollection<HistorialCartaNombramiento> HistorialCartaNombramientos { get; set; } = new List<HistorialCartaNombramiento>();
}
