using SistemaVenta.IOC;
namespace SistemaVenta.API
{
    using SistemaVenta.IOC;
    public class Program
    {
      
        public static void Main(string[] args)
        {
          
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.InyectarDependencias(builder.Configuration);

            builder.Services.AddCors(options =>{
                options.AddPolicy("NuevaPolitica", app =>{
                    app.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });

            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("NuevaPolitica");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}