using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Pinacoteca.Models.Entities;
using Pinacoteca.Repositories;

var builder = WebApplication.CreateBuilder(args);


//agg el repositorio como servicio:
builder.Services.AddTransient<Repository<Coleccion>>();
builder.Services.AddTransient<Repository<Pintor>>();
builder.Services.AddTransient<CuadrosRepository>();

builder.Services.AddDbContext<PinacotecabdContext>(x => x.UseMySql("server=localhost;password=root;user=root;database=pinacotecabd",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql")));

builder.Services.AddMvc();
var app = builder.Build();

app.UseFileServer();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapDefaultControllerRoute();
app.Run();
