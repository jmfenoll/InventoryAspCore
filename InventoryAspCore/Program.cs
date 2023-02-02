using Inventory.Infrastructure.EFSqlRepository.Context;
using Inventory.Infrastructure.Models;
using Inventory.Infrastructure.Models.Interfaces;
using Inventory.Mvc.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("InventoryDatabase")));


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDatabaseDeveloperPageExceptionFilter();


ConfigureServices(builder.Services);


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


void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IRepository<Product>, ProductRepository>();
    services.AddTransient<ProductService, ProductService>();
}