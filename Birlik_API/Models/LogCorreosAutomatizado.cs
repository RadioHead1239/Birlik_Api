using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class LogCorreosAutomatizado
{
    public int IdLogCorreosAutomatizados { get; set; }

    public string? TipoCorreo { get; set; }

    public string? CategoriaCorreo { get; set; }

    public DateTime? FechaHoraProgramada { get; set; }

    public DateTime? FechaHoraEnvio { get; set; }

    public string? DestinarioCorreo { get; set; }

    public string? CopiasCorreo { get; set; }

    public string? AsuntoCorreo { get; set; }

    public string? ImagenCabecera { get; set; }

    public string? EstadoEnvio { get; set; }

    public string? MensajeError { get; set; }

    public string? CodigoErrorApi { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkCuota { get; set; }

    public int? FkTarea { get; set; }

    public int? FkGps { get; set; }

    public string? MetadatosJson { get; set; }

    public int? DuracionEnvioMs { get; set; }

    public int? IntentosRealizados { get; set; }

    public string? CreadoPor { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
