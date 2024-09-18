using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Olimpiadas.Infrastructure.Persistence;
using SportStyle.Presentation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Obtener la conexion a la base de datos
var connectionString = builder.Configuration.GetConnectionString("Olimpiadas");

// Falta solucionar el tipo MysqlServerVesion
builder.Services.AddDbContext<OlimpiadasDbContext>(opcion =>
    opcion.UseMySQL(connectionString, new MySqlServerVersion(new Version(8, 0, 33))));

var opciones = new DbContextOptionsBuilder<OlimpiadasDbContext>();

// Falta solucionar el tipo MysqlServerVesion
opciones.UseMySQL(connectionString, new MySqlServerVersion(new Version(8, 0, 33)));

var contexto = new OlimpiadasDbContext(opciones.Options);

contexto.Database.EnsureCreated();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
