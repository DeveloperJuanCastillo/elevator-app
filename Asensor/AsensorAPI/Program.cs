using ElevatorAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IElevatorRepository, ElevatorRepository>();

builder.Services.AddCors(options => { 
    options.AddPolicy("AllowAll", policy => { 
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    }); 
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();
