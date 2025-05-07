using Microsoft.EntityFrameworkCore;

namespace ProjetoColaborador.Data
{
    public static class DepedencyInjection
    {

        public static void addDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("Connection");

            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 42));

            service.AddDbContext<ColaboradorDbContext>(dbContextOptions =>
            dbContextOptions.UseMySql(connectionString, serverVersion)

            );
        }
    }
}
