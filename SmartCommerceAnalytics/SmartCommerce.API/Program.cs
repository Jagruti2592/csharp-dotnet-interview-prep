using SmartCommerce.API.Middlewares;
using SmartCommerce.Application;
using SmartCommerce.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

//Configure middlewware

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();


app.Run();

