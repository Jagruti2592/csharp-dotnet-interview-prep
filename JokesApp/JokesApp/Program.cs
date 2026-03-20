using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JokesApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<JokesAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JokesAppContext") ?? throw new InvalidOperationException("Connection string 'JokesAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
