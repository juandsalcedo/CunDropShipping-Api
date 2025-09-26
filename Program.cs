using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application.Service;
using CunDropShipping.Api.Infraestructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Conexión y Registros ---

// Revisa que el nombre en appsettings.json sea "DefaultConnection"
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 1. Registro del DbContext (MySQL)
builder.Services.AddDbContext<ClientDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// 2. Registro del Repositorio
builder.Services.AddScoped<IClientRepository_cs_, ClientRepositoryImp>();

// 3. ¡NUEVO! Registro del Mapper (El Traductor)
builder.Services.AddScoped<IInfraestructureMapper, InfrastructureMapperImp>();

// 4. Registro del Servicio
builder.Services.AddScoped<IClientService, ClientServiceImp>();

// --- Configuración por defecto ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- Pipeline de HTTP ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
