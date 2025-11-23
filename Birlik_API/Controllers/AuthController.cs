using Birlik.Data;
using Birlik_Api.Models.DTO;
using Birlik_Api.Models.Response;
using Birlik_Api.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Birlik_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly JwtHelper _jwtHelper;

        public AuthController(ApplicationDbContext context, JwtHelper jwtHelper)
        {
            _context = context;
            _jwtHelper = jwtHelper;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
                if (string.IsNullOrWhiteSpace(request.Correo) || string.IsNullOrWhiteSpace(request.PasswordHash))
                return BadRequest(new { message = "Debe ingresar usuario y contraseña" });

            var user = _context.DetalleUsuario
                .FirstOrDefault(u => u.Correo == request.Correo && u.ClaveCorreo == request.PasswordHash);

            if (user == null)
                return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

            var token = _jwtHelper.GenerateToken(
                user.NombreUsuario ?? user.Correo,
                user.Correo,
                user.RolUsuario ?? "Usuario"
            );

            var response = new LoginResponse
            {
                Correo = user.Correo,
                Nombre = user.NombreUsuario,
                Rol = user.RolUsuario,
                Token = token
            };

            return Ok(response);
        }
    }
}
