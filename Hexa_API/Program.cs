using Hexa_API.Domain.IRepositories;
using Hexa_API.Domain.IServices;
using Hexa_API.Persistence.Context;
using Hexa_API.Persistence.Repositories;
using Hexa_API.Services;
using Hexa_API.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//configuracion conexión sql server
builder.Services.AddDbContext<AplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql"), sqlServerOptions =>
    {
        sqlServerOptions.EnableRetryOnFailure();
    });
});

// Add services to the container.
builder.Services.AddScoped<IJugadoresServices, JugadoresService>();
builder.Services.AddScoped<IEquiposService, EquiposService>();

// Add Repository
builder.Services.AddScoped<IJugadoresRepository, JugadoresRepository>();
builder.Services.AddScoped<IEquiposRepository, EquiposRepository>();


//CORS
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                                            builder => builder.AllowAnyOrigin()
                                                              .AllowAnyHeader()
                                                              .AllowAnyMethod()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowWebApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
