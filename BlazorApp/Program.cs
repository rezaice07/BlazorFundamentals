using BlazorApp.Authentication;
using BlazorApp.Data;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

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
    services.AddSingleton<ProductService>();
    services.AddSingleton<UserAccountService>();
    
    services.AddSingleton<ProtectedSessionStorage>();
    services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
    services.AddScoped<IJSRuntime>();

    //services.AddTransient<ContactService>();
}
