using Microsoft.AspNetCore.Mvc;

namespace Birlik_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioVoiceController : ControllerBase
    {
        [HttpGet("voice")]
        public IActionResult GetVoiceMessage([FromQuery] string message = "Se ha detectado una emergencia. Por favor revise la aplicación Birlik.")
        {
            var xml = $@"<?xml version=""1.0"" encoding=""UTF-8""?>
            <Response>
                <Say language=""es-ES"" voice=""alice"">
                    {message}
                </Say>
            </Response>";

            return Content(xml, "application/xml");
        }
    }
}
