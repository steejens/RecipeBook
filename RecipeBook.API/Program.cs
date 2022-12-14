using System.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Application;
using RecipeBook.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddControllers();
builder.Services.ConfigureDependencyInjections(builder.Configuration, new DependencyInjectionOptions()
{
    AutoMapperAssemblies = new Assembly[]
    {
        typeof(Program).Assembly,
        typeof(DependencyInjection).Assembly,

    },
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("Settings/appsettings.json",
        optional: false,
        reloadOnChange: true);
});

var app = builder.Build();
app.UseCors();
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
