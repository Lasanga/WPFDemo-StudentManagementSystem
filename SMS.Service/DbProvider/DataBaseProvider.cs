using MySql.Data.MySqlClient;
using System.Configuration;

namespace SMS.Service.DbProvider
{
    public class DataBaseProvider : IDbProvider
    {
        public MySqlConnection GetDbConnection()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionStrings"];

            return new MySqlConnection(connectionString);
        }
    }
}
