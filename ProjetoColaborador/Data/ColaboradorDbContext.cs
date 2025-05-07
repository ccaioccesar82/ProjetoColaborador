using Microsoft.EntityFrameworkCore;
using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data
{
    public class ColaboradorDbContext: DbContext
    {

        public ColaboradorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Colaborador> Colaboradores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColaboradorDbContext).Assembly);
        }
    }
}
