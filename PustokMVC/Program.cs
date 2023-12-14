using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;
using PustokMVC.Models;
using PustokMVC.ViewComponents;

namespace PustokMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<PustokDbContext>(
                options =>
            options.UseSqlServer("Server=DESKTOP-U9AO5GJ\\SQLEXPRESS;Database=PustokDB;Trusted_Connection=True")
            );
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=Slider}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            

            app.Run();
        }
    }
}