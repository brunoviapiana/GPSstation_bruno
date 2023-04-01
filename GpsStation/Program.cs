
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

//cria objeto do tipo IConfigurationBuilder e cria ligação com appsettings.jason
//var config = new ConfigurationBuilder()
    //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
   // .Build();

//cria variável que recebe o valor da sessão do appsettings.json selecionada
//var value = config.GetConnectionString("DataBase");

// cria o serviço da conexão do banco de dados
// a string de conexão fica em appsettings.jason e é passada pela variável value
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
