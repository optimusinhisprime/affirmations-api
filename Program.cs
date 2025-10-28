using Microsoft.EntityFrameworkCore;
using AffirmationsAPI.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

// registering the database connection
builder.Services.AddDbContext<ApiDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); 
}

// this enables HTTPS redirection middleware
app.UseHttpsRedirection();
// this enables authorization middleware
app.UseAuthorization();
// this maps controllers to endpoints
app.MapControllers();
// this runs the application
app.Run();
