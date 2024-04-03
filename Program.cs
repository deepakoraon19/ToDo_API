using Microsoft.EntityFrameworkCore;
using ToDo_API.Models;
using ToDo_API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configBuilder = new ConfigurationBuilder();
configBuilder.AddJsonFile("appsettings.json", optional: false,reloadOnChange: true);
var configuration = configBuilder.Build(); 
var settingValue = configuration["ConnectionString"];

builder.Services.AddDbContext<TODOContext>(
        options => options.UseSqlServer(settingValue));

builder.Services.AddTransient<UserService>();
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
