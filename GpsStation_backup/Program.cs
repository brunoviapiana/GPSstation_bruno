
using GpsStation.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

//----------------------------------------------------------------------------------

//cria objeto do tipo IConfigurationBuilder e cria liga��o com appsettings.jason
//var config = new ConfigurationBuilder()
    //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
   // .Build();

//cria vari�vel que recebe o valor da sess�o do appsettings.json selecionada
//var value = config.GetConnectionString("DataBase");

// cria o servi�o da conex�o do banco de dados
// a string de conex�o fica em appsettings.jason e � passada pela vari�vel value
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=ACER_B\\TEW_SQLEXPRESS;Initial Catalog=GPSStation;Integrated Security=False;Id=user;Password=1234"));

//---------------------------------------------------------------------------------

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
