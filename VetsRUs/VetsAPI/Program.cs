
using Microsoft.EntityFrameworkCore;
using static VetsAPI.Data.ApplicationDbContext;

namespace VetsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbConnect>(options =>
            {
                options.UseSqlServer(Environment.GetEnvironmentVariable("SQL_CONNECTION_STRING"));
            }); 



            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            app.UseSwagger();
            app.UseSwaggerUI();
            

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("cats", async (ApplicationDbConnect context) => await context.Cats.ToListAsync());
            app.MapGet("dogs", async (ApplicationDbConnect context) => await context.Dogs.ToListAsync());

            app.Run();
        }
    }
}
