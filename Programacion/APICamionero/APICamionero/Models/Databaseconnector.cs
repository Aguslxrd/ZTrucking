using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public abstract class DatabaseConnector
    {
        public string dbip;
        public string dbUser;
        public string dbPassword;
        public string dbDatabaseName;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader Reader;

        public DatabaseConnector()
        {
            this.dbip = "192.168.5.50";
            this.dbUser = "damian.suffo";
            this.dbPassword = "52949224";
            this.dbDatabaseName = "damian_suffo";

            try
            {
                this.Connection = new MySqlConnection(
                    $"server={this.dbip};" +
                    $"user={this.dbUser};" +
                    $"password={this.dbPassword};" +
                    $"database={this.dbDatabaseName};");

                this.Connection.Open();
                this.Command = new MySqlCommand();
                this.Command.Connection = this.Connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

    }
}