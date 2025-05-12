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
        {//Método de extensão para injetar as dependências do database, services e repositories.

            AddDbContext(service, configuration);
            AddRepositories(service);
            AddServices(service);
        }


        private static void AddDbContext(IServiceCollection service, IConfiguration configuration)
        {
            //Tenta se conectar com as informações de connectionstring que estão no appsettingDevelopment.
            //Obs: é necessário que o Uid e a password sejam trocadas de acordo as informações da sua máquina local.
            string? connectionString = configuration.GetConnectionString("Connection");

            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 42)); //Versão do banco mysql

            service.AddDbContext<ColaboradorDbContext>(dbContextOptions =>
            dbContextOptions.UseMySql(connectionString, serverVersion)

            );
        }


        private static void AddRepositories(IServiceCollection service)
        {
            service.AddScoped<IReadColaboradorRepository, ReadColaboradorRepository>();
            service.AddScoped<IWriteColaboradorRepository, WriteColaboradorRepository>();

        }

        private static void AddServices(IServiceCollection service)
        {
            service.AddScoped<IFindColaboradorService, FindColaboradorService>();
            service.AddScoped<IColaboradorCreateService, ColaboradorCreateService>();
            service.AddScoped<IEditColaboradorService, EditColaboradorService>();
        }
    }
}
