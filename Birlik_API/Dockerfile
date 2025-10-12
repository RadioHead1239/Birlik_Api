# Etapa 1: Compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar solo el .csproj y restaurar dependencias
COPY ["Birlik_Api.csproj", "."]
RUN dotnet restore "Birlik_Api.csproj"

# Copiar todo el proyecto
COPY . .
RUN dotnet publish "Birlik_Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa 2: Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:5277
EXPOSE 5277
ENTRYPOINT ["dotnet", "Birlik_Api.dll"]
