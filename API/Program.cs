using API.Extensions;
using Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {  
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "allowedCors",
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200/")
                                      .AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                                  });
            });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.RegisterServices();
            builder.Services.RegisterRepositories();

            builder.Services.AddDbContext<DataStoreDbContext>(options => options.UseInMemoryDatabase("DataStore"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // app.UseHttpsRedirection();

            app.UseCors("allowedCors");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}