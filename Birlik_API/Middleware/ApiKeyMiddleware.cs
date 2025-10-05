namespace Birlik_Api.Middleware
{
    public class ApiKeyMiddleware
    {

        private readonly RequestDelegate _next;
        private const string APIKEY_HEADER = "x-api-key";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IConfiguration config)
        {
            var expectedApiKey = config["ApiSettings:ApiKey"];
            if (!context.Request.Headers.TryGetValue(APIKEY_HEADER, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Falta el encabezado de API Key.");
                return;
            }
            if (!expectedApiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key inválida.");
                return;
            }
            await _next(context);
        }
    }
}
