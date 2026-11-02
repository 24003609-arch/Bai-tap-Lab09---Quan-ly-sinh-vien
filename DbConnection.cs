
using MySql.Data.MySqlClient;

namespace Lab09_DataReaderSearch12
{
    public class DbConnection
    {
        private static string connectionString =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=QLSinhVien;" +
            "Uid=root;" +
            "Pwd=12345678;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
