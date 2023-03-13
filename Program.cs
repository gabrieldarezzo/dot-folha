using DemoMicroService.Data;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SeedingService>();


var seedingService = builder.Services.BuildServiceProvider().GetService<SeedingService>();
seedingService.Seed();



var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();
app.Run();
