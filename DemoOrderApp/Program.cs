using Bussiness;
using Domain.Entites;
using Repository.Abstraction;
using Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using DemoOrderApp.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Bussiness.Abstraction;
using Bussiness.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<OrderRepository, OrderRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<ICartRepository, CartRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICartItemRepository, CartItemRepository>();
builder.Services.AddTransient<IItemRepository, ItemRepository>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
    
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<ICartItemService, CartItemService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer
(builder.Configuration.GetConnectionString("OrderDB")));

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
