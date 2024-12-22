using Microsoft.EntityFrameworkCore;
using Sportlife.Data;

namespace Sportlife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataEFContext>(opt =>
             opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQLConnection")));


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
                pattern: "{controller=Gym}/{action=ShowListGym}/{id?}");

            app.Run();
        }
    }
}
