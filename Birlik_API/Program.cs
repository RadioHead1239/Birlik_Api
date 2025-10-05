using Birlik_Api.Middleware;
using Birlik_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//este código builder se debe de integrar en el 
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Birlik API", Version = "v1" });

//     🔹 Configurar header para x-api-key
//    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
//    {
//        In = ParameterLocation.Header,
//        Name = "x-api-key",
//        Type = SecuritySchemeType.ApiKey,
//        Description = "Ingrese su API Key para acceder a los endpoints."
//    });

//    c.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "ApiKey"
//                }
//            },
//            new string[] {}
//        }
//    });
//});




var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();

app.Run();
