using Microsoft.Extensions.DependencyInjection;

namespace Birlik_Api.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<TwilioService>();


            return services;
        }
    }
}
