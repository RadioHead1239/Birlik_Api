namespace Birlik_Api.Models.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;

    }
}
