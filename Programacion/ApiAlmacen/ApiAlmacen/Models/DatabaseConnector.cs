using System;
using MySqlConnector;

namespace ApiAlmacen.Models
{
    public abstract class DatabaseConnector : IDisposable
    {
        private string dbip = "192.168.5.50";
        private string dbUser = "damian.suffo";
        private string dbPassword = "52949224";
        private string dbDatabaseName = "damian_suffo";

        protected MySqlConnection Connection;
        protected MySqlCommand Command;
        protected MySqlDataReader Reader;

        public DatabaseConnector()
        {
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            try
            {
                Connection = new MySqlConnection(
                    $"server={dbip};" +
                    $"user={dbUser};" +
                    $"password={dbPassword};" +
                    $"database={dbDatabaseName};");

                Connection.Open();
                Command = new MySqlCommand();
                Command.Connection = Connection;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void Dispose()
        {
            Connection?.Close();
            Connection?.Dispose();
        }
    }
}
