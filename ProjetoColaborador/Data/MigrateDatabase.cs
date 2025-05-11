using Dapper;
using MySqlConnector;

namespace ProjetoColaborador.Data
{
    public static class MigrateDatabase
    {
        
        // Verifica se o database com o nome "colaboradorgestao" existe na máquina local na primeira vez que o programa for rodado na máquina.
        //Obs: Somente o schema é criado, sem as tabelas. Após a criação do database, executar o "update-database" para executar as migrations de tabelas.
        public static void EnsureDatabaseIsCreated(string connectionString)
        {

            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder(connectionString);

            string dataBaseName = connectionStringBuilder.Database;

            connectionStringBuilder.Remove("Database");

            using MySqlConnection dbConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("name", dataBaseName);

            IEnumerable<dynamic> records = dbConnection.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @name", parameters);

            if (records.Any() == false)
            {
                dbConnection.Execute($"CREATE DATABASE {dataBaseName}");

            }

        }
    }
}

