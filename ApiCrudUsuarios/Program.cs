
using ApiCrudUsuarios.Data;
using ApiCrudUsuarios.Repositories;
using ApiCrudUsuarios.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCrudUsuarios
{
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

            // Configuração Nova
            builder.Services.AddEntityFrameworkSqlServer()
            .AddDbContext<SistemaDBContex>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
            );
            builder.Services.AddScoped<IUsuarioRepositorie, UsuarioRepositorie>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
