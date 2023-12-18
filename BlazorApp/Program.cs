using BlazorApp.Data;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub(); 
app.MapFallbackToPage("/_Host");

app.Run();

static void ConfigurationServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.AddServerSideBlazor();
    services.AddSingleton<WeatherForecastService>();
    //services.AddSingleton<ContactService>();
    services.AddSingleton<IContactService,ContactService>();   

    //services.AddTransient<ContactService>();
}
