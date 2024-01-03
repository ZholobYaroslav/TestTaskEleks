
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using TestTask.Server.Entities;
using TestTask.Server.Services;

namespace TestTask.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContextPool<AppDbContext>(options => 
            options.UseSqlServer("Server=DESKTOP-QSL5KI2;Database=TestTaskDB;Trusted_Connection=True;TrustServerCertificate=True;"));
            builder.Services.AddScoped<IOperations<Student>, StudentService>();
            builder.Services.AddScoped<IOperations<User>, UserService>();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
