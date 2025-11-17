namespace Birlik_Api.Models.Response
{
    public class ConstanciaDTO
    {
        public string? TituloDocumento { get; set; }
        public string? RutaDocumento { get; set; }
    }

    public class PolizaResponseDTO
    {
        public int IdPoliza { get; set; }
        public string? NumeroPoliza { get; set; }
        public string? NombreRamo { get; set; }
        public string? NombreCompania { get; set; }
        public int? Trazabilidad { get; set; }
        public DateOnly? VigenciaInicio { get; set; }
        public DateOnly? VigenciaFin { get; set; }
        public ConstanciaDTO? Constancia { get; set; }
    }

}
