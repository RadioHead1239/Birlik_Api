namespace Birlik_Api.Models.Response
{
    public class LoginResponse
    {
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Token { get; set; }
        public string Message { get; set; } = "¡Bienvenido!";
    }
}
