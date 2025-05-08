using Microsoft.EntityFrameworkCore;
using ProjetoColaborador.Data.Repositories;
using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Services;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Data
{
    public static class DepedencyInjection
    {


        public static void AddDepedencies(this IServiceCollection service, IConfiguration configuration)
        {
            addDbContext(service, configuration);
            addRepositories(service);
            addServices(service);
        }


        private static void addDbContext(IServiceCollection service, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("Connection");

            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 42));

            service.AddDbContext<ColaboradorDbContext>(dbContextOptions =>
            dbContextOptions.UseMySql(connectionString, serverVersion)

            );
        }


        private static void addRepositories(IServiceCollection service)
        {
            service.AddScoped<IReadColaboradorRepository, ReadColaboradorRepository>();
            service.AddScoped<IWriteColaboradorRepository, WriteColaboradorRepository>();

        }

        private static void addServices(IServiceCollection service)
        {
            service.AddScoped<IFindColaboradorService, FindColaboradorService>();
        }
    }
}
