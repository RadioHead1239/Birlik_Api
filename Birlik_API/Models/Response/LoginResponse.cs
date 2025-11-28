using Birlik_Api.Models.DTO;

namespace Birlik_Api.Models.Response
{
    public class LoginResponse
    {
        public UsuarioDTO Usuario { get; set; } = new UsuarioDTO();
        public string Token { get; set; } = string.Empty;
        public string Message { get; set; } = "¡Bienvenido!";
    }
}
