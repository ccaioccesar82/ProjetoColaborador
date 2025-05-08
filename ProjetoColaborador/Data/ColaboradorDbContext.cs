using Microsoft.EntityFrameworkCore;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Models.Entities.Enums;

namespace ProjetoColaborador.Data
{
    public class ColaboradorDbContext: DbContext
    {

        public ColaboradorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Cargos> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColaboradorDbContext).Assembly);

                        modelBuilder
                        .Entity<Colaborador>()
                        .Property(e => e.CargoId)
                        .HasConversion<int>();

                  modelBuilder
                .Entity<Cargos>()
                .Property(e => e.Id)
                .HasConversion<int>();

                 modelBuilder
                .Entity<Cargos>().HasData(
                    Enum.GetValues(typeof(CargosId))
                        .Cast<CargosId>()
                        .Select(e => new Cargos()
                        {
                            Id = e,
                            Name = e.ToString()
                        })                       
                        );
        }
    }
}
