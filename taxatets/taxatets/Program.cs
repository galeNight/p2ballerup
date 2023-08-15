using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using taxatets.data;
using taxatets.service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

Parameters obj = new Parameters { startingprices = 37m, priceprkm = 12.75m, priceprmin = 5.75m };
Parameterservice pm = new Parameterservice(obj);
pm.DoThis();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/hot go _Host");

app.Run();
