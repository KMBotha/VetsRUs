
using Microsoft.EntityFrameworkCore;
using VetsAPI.Models;
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


            // GET cats
            app.MapGet("cats", async (ApplicationDbConnect context) => await context.Cats.ToListAsync());
           
            // GET a cat by id
            app.MapGet("/cats/{id}", async (ApplicationDbConnect context, int id) =>
                await context.Cats.FindAsync(id) is Cat cat ? Results.Ok(cat) : Results.NotFound());

            // Create a new cat entry
            app.MapPost("/addcat", async (ApplicationDbConnect context, Cat cat) =>
            {
                context.Cats.Add(cat);
                await context.SaveChangesAsync();
                return Results.Created($"/cats/{cat.CatID}", cat);
            });

            // Update an existing cat entry
            app.MapPut("/cats/{id}", async (ApplicationDbConnect context, int id, Cat updatedCat) =>
            {
                var cat = await context.Cats.FindAsync(id);
                if (cat is null) return Results.NotFound();

                cat.Name = updatedCat.Name;
                cat.Breed = updatedCat.Breed;
                cat.OwnerName = updatedCat.OwnerName;
                cat.OwnerNumber = updatedCat.OwnerNumber;
                cat.Age = updatedCat.Age;
                cat.Weight = updatedCat.Weight;
                cat.Conditions = updatedCat.Conditions;

                await context.SaveChangesAsync();
                return Results.Ok(cat);
            });

            // Delete a cat
            app.MapDelete("/removecat/{id}", async (ApplicationDbConnect context, int id) =>
            {
                var cat = await context.Cats.FindAsync(id);
                if (cat is null) return Results.NotFound();

                context.Cats.Remove(cat);
                await context.SaveChangesAsync();
                return Results.NoContent();
            });
            
            // GET dogs
            app.MapGet("dogs", async (ApplicationDbConnect context) => await context.Dogs.ToListAsync());

            // GET a dog by id
            app.MapGet("/dogs/{id}", async (ApplicationDbConnect context, int id) =>
                await context.Dogs.FindAsync(id) is Dog dog ? Results.Ok(dog) : Results.NotFound());

            // Create a new dog entry
            app.MapPost("/adddog", async (ApplicationDbConnect context, Dog dog) =>
            {
                context.Dogs.Add(dog);
                await context.SaveChangesAsync();
                return Results.Created($"/cats/{dog.DogID}", dog);
            });

            // Update an existing dog entry
            app.MapPut("/dogs/{id}", async (ApplicationDbConnect context, int id, Dog updatedDog) =>
            {
                var dog = await context.Dogs.FindAsync(id);
                if (dog is null) return Results.NotFound();

                dog.Name = updatedDog.Name;
                dog.Breed = updatedDog.Breed;
                dog.OwnerName = updatedDog.OwnerName;
                dog.OwnerNumber = updatedDog.OwnerNumber;
                dog.Age = updatedDog.Age;
                dog.Weight = updatedDog.Weight;
                dog.Conditions = updatedDog.Conditions;
                

                await context.SaveChangesAsync();
                return Results.Ok(dog);
            });

            // Delete a cat
            app.MapDelete("/removedog/{id}", async (ApplicationDbConnect context, int id) =>
            {
                var dog = await context.Dogs.FindAsync(id);
                if (dog is null) return Results.NotFound();

                context.Dogs.Remove(dog);
                await context.SaveChangesAsync();
                return Results.NoContent();
            });


            app.Run();

        }
    }
}
