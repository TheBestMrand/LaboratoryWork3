using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using LaboratoryWork3.Models;
using LaboratoryWork3.Models.Services;
using LaboratoryWork3.ViewModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserAuthenticationViewModel>();
builder.Services.AddBlazorise(option =>
{
    option.Immediate = true;
}).AddBootstrapProviders()
    .AddFontAwesomeIcons();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();