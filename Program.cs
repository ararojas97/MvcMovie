var builder = WebApplication.CreateBuilder(args);

// Agregar servicios MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar rutas para MVC
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
