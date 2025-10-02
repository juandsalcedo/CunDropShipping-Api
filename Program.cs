using CunDropShipping.Api.Adapter.Restul.v1.Controllers.Mapper;
using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application.Service;
using CunDropShipping.Api.Infraestructure;
using CunDropShipping.Api.Infraestructure.Mapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ClientDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 39)) 
    )
);


builder.Services.AddScoped<Repository>();


builder.Services.AddScoped<IInfraestructureMapper, InfrastructureMapperImp>();
builder.Services.AddScoped<IAdapterMapper, AdapterMapperImp>();


builder.Services.AddScoped<IClientService, ClientServiceImp>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
