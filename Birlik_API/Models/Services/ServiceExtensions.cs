using Birlik.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace Birlik_Api.Models.Services
{
    /// <summary>
    /// Métodos de extensión para registrar toda la configuración
    /// (Base de datos, JWT, servicios personalizados, etc.)
    /// </summary>
    public static class ServiceExtensions
    {

        public static void AddAllAppConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseConfiguration(configuration);
            services.AddJwtAuthentication(configuration);
            services.AddAppServices();
        }

  
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
#if DEBUG
            var conn = configuration.GetConnectionString("LocalConnection");
#else
            var conn = configuration.GetConnectionString("DefaultConnection");
#endif
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(conn));
        }

        public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSection = configuration.GetSection("Jwt");
            var key = Encoding.UTF8.GetBytes(jwtSection["Key"]);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
#if DEBUG
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = false, 
                    ValidIssuer = jwtSection["Issuer"],
                    ValidAudience = jwtSection["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
#else
                // 🔹 Producción: token con expiración
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true, // Expira según 'exp'
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = jwtSection["Issuer"],
                    ValidAudience = jwtSection["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
#endif
            });
        }

        /// <summary>
        /// Registra los servicios personalizados de la aplicación (helpers, repositorios, etc.).
        /// </summary>
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<JwtHelper>();
        }
    }
}
