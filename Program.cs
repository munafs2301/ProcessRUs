using Microsoft.EntityFrameworkCore;
using ProcessRUs.Data;

namespace ProcessRUs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ProcessRUsContext>(opt => opt.UseInMemoryDatabase("ProcessRUsDevDb"));

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

            app.UseAuthorization();

            app.MapControllers();

            app.PrepDb();

            app.Run();
        }
    }
}