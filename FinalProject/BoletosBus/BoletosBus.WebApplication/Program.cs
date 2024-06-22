using BoletosBus.WebApplication.Implementation;
using BoletosBus.WebApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Agregar configuración desde appsettings.json
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

// Agregar HttpClientFactory
builder.Services.AddHttpClient<IUsuarioService, UsuarioServiceImplementation>(client =>
{
    var baseUrl = builder.Configuration.GetSection("ApiConfig:baseUrl").Value;
    client.BaseAddress = new Uri(baseUrl);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
