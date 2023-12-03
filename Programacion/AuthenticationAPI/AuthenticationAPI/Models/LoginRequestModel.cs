using AuthenticationAPI.Controllers;
using MD5Hash;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationAPI.Models
{
    public class LoginRequestModel : DatabaseConnector
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Password { get; set; }


        public Dictionary<string, string> LoginRequest()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.UserName))
            {
                result.Add("resultado", "Error");
                result.Add("mensaje", "Datos obligatorios.");
                return result;
            }

            this.Command.CommandText = $"SELECT pass, id FROM trabajador WHERE username = '{this.UserName}'";
            this.Reader = this.Command.ExecuteReader();

            if (this.Reader.HasRows)
            {
                this.Reader.Read();
                string dbPassword = this.Reader["pass"].ToString();
                int userId = Convert.ToInt32(this.Reader["id"]);

                if (Hash.Content(this.Password) == dbPassword)
                {
                    result.Add("resultado", "OK");
                    result.Add("id", userId.ToString());

                    if (IsInTable("camionero", userId, "id_camionero"))
                    {
                        result.Add("tipo", "camionero");
                    }
                    else if (IsInTable("operario", userId, "id_operario"))
                    {
                        result.Add("tipo", "operario");
                    }
                    else
                    {
                        result.Add("tipo", "no asignado");
                    }

                    return result;
                }
            }

            result.Add("resultado", "Error");

            return result;
        }

        private bool IsInTable(string tableName, int userId, string idColumnName)
        {
            bool isInTable = false;

            if (this.Reader != null && !this.Reader.IsClosed)
            {
                this.Reader.Close();
            }

            this.Command.CommandText = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumnName} = {userId}";

            try
            {
                int count = Convert.ToInt32(this.Command.ExecuteScalar());
                isInTable = count > 0;
            }
            catch (Exception)
            {

            }

            this.Command.CommandText = "";

            return isInTable;
        }

    }
}
