using Birlik_Api.Models.Services;
using Birlik_Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAllAppConfigurations(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication(); 
app.UseAuthorization();
app.UseMiddleware<ApiKeyMiddleware>(); 

app.MapControllers();

app.Run();
