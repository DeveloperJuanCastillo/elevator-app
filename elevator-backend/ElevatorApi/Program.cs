using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => { 
    options.AddPolicy("AllowAll", policy => { 
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); 
    }); 
});

// Agregar servicios necesarios
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<Elevator>();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el middleware
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

// Definir los endpoints de la API
app.MapGet("/{name}", (string name) => $"�Hola {name}!");

app.MapPost("/call/{floor}", (int floor, Elevator elevator) =>
{
    elevator.Call(floor);
    return Results.Ok(new { message = $"Elevator called to floor {floor}" });
});

app.MapGet("/api/hello", () => new { mensaje = "�Bienvenido a la API!" });

// Corriendo la aplicaci�n
app.Run();
