using ApiCrudUsuarios.Data.Map;
using ApiCrudUsuarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiCrudUsuarios.Data
{
    public class SistemaDBContex : DbContext
    {
        public SistemaDBContex(DbContextOptions<SistemaDBContex> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
