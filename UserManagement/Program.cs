
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using UserManagement.BussinessLogic.Data;
using UserManagement.BussinessLogic.Interfaces;
using UserManagementDataAccessLayer.Data;
using UserManagementDataAccessLayer.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
        // Add services to the container.
        builder.Services.AddControllersWithViews();
        string connectionString = configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddScoped(_ => new SqlConnection(connectionString));
        builder.Services.AddTransient<IUserService, UserService>();
        builder.Services.AddTransient<IUserRepository, UserRepository>();
        builder.Services.Configure<DatabaseOptions>(x => x.ConnectionString = connectionString);
                // builder.Services.Configure<DatabaseOptions>("", configuration.GetConnectionString("DefaultConnection"));
                //builder.Services.AddTransient<IUserService, UserService>();



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
    }
}