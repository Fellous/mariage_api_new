using Microsoft.EntityFrameworkCore;
using mariage_api_new.Data;
using mariage_api_new.Models; // Assurez-vous que cela pointe vers le bon espace de noms où se trouvent vos modèles.
using MySql.EntityFrameworkCore;

// Make sure this is pointing to the correct namespace where your models are located.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Entity Framework Core services.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"))); // Utilisez UseMySQL ici

// Add Swagger generation tool if you need it.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();