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

            if (string.IsNullOrEmpty(expectedApiKey))
            {
                Console.WriteLine("⚠️ No se encontró ApiSettings:ApiKey en appsettings.json");
            }

            context.Response.OnStarting(() =>
            {
                var receivedKey = context.Request.Headers.ContainsKey(APIKEY_HEADER)
                    ? context.Request.Headers[APIKEY_HEADER].ToString()
                    : "(sin header)";
                context.Response.Headers["X-Diag-ApiKey-Received"] = receivedKey;
                return Task.CompletedTask;
            });

            if (!context.Request.Headers.TryGetValue(APIKEY_HEADER, out var extractedApiKey))
            {
                Console.WriteLine(" Falta el encabezado de API Key");
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Falta el encabezado de API Key.");
                return;
            }

            Console.WriteLine($"Middleware ejecutado: {extractedApiKey}");

            if (expectedApiKey != extractedApiKey)
            {
                Console.WriteLine($"API Key inválida. Esperada: {expectedApiKey} / Recibida: {extractedApiKey}");
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key inválida.");
                return;
            }

            await _next(context);
        }
    }
}
