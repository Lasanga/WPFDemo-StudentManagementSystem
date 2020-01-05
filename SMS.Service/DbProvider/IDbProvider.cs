using MySql.Data.MySqlClient;

namespace SMS.Service.DbProvider
{
    public interface IDbProvider
    {
        MySqlConnection GetDbConnection();
    }
}