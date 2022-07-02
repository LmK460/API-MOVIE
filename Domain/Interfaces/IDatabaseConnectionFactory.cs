using Npgsql;

namespace Domain.Interfaces
{
    public interface IDatabaseConnectionFactory
    {
        Task<NpgsqlConnection> GetConnectionFactoryAsync();
    }
}
