
using Penu.Application.Extensions;
using Penu.Infrastructure.Extensions;
using Penu.Persistence.Extensions;

namespace Penu.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddInfrastructureServices();
            builder.Services.AddApplicationServices();


            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
