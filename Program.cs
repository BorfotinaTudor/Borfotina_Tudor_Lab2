using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Borfotina_Tudor_Lab2.Data;
using Borfotina_Tudor_Lab2.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Borfotina_Tudor_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Borfotina_Tudor_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Borfotina_Tudor_Lab2Context' not found.")));
builder.Services.AddDbContext<Borfotina_Tudor_Lab2.Data.LibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Borfotina_Tudor_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Borfotina_Tudor_Lab2Context' not found.")));

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

