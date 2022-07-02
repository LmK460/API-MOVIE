using Domain.Interfaces;
using Npgsql;

namespace Infra.Configuration
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        private string ConnectionString { get; }

        public DatabaseConnectionFactory(string connectionString) =>
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));

        public async Task<NpgsqlConnection> GetConnectionFactoryAsync()
        {
            var connection = new NpgsqlConnection(ConnectionString);
            await connection.OpenAsync();
            return connection;
        }

    }
}
