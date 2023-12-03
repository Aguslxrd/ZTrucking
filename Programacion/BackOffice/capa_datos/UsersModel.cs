using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD5Hash;

namespace capa_datos
{
    public class UsersModel : DataBaseControl
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string FirstLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActivedUser { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO trabajador (nom, ape, bajalogica, tel, username, pass) " +
                "VALUES (@FirstName, @FirstLastName, @ActivedUser, @PhoneNumber, @UserName, @Password)";

                this.Command.Parameters.AddWithValue("@FirstName", this.FirstName);
                this.Command.Parameters.AddWithValue("@FirstLastName", this.FirstLastName);
                this.Command.Parameters.AddWithValue("@ActivedUser", this.ActivedUser);
                this.Command.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                this.Command.Parameters.AddWithValue("@UserName", this.UserName);
                this.Command.Parameters.AddWithValue("@Password", Hash.Content(this.Password));

                this.Command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<UsersModel> GetAllUsers()
        {
            this.Command.CommandText = $"SELECT * FROM trabajador";
            this.Reader = this.Command.ExecuteReader();

            List<UsersModel> result = new List<UsersModel>();
            while (this.Reader.Read())
            {
                UsersModel user = new UsersModel();
                user.UserID = Int32.Parse(this.Reader["id"].ToString());
                user.FirstName = this.Reader["nom"].ToString();
                user.FirstLastName = this.Reader["ape"].ToString();
                user.ActivedUser = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
                user.PhoneNumber = (this.Reader["tel"].ToString());
                user.UserName = this.Reader["username"].ToString();
                result.Add(user);
            }
            return result;
        }

        public void DeleteUser()
        {
            this.Command.CommandText = $"DELETE FROM trabajador where id = {this.UserID}";
            this.Command.ExecuteNonQuery();
        }

        public bool CheckIfUserExists(int userId)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM trabajador WHERE id = {userId}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }


        public void EditUser()
        {
            bool userExists = CheckIfUserExists(this.UserID);

            if (userExists)
            {
                try
                {
                    this.Command.CommandText = "UPDATE trabajador SET " +
                        "username = @UserName, " +
                        "nom = @FirstName, " +
                        "ape = @FirstLastName, " +
                        "bajalogica = @ActivedUser, " +
                        "tel = @PhoneNumber " +
                        "WHERE id = @UserID";

                    this.Command.Parameters.AddWithValue("@UserName", this.UserName);
                    this.Command.Parameters.AddWithValue("@FirstName", this.FirstName);
                    this.Command.Parameters.AddWithValue("@FirstLastName", this.FirstLastName);
                    this.Command.Parameters.AddWithValue("@ActivedUser", this.ActivedUser);
                    this.Command.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                    this.Command.Parameters.AddWithValue("@UserID", this.UserID);

                    this.Command.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
            else
            {
                throw new Exception($"El usuario con ID {this.UserID} no existe en la base de datos.");
            }
        }


    }
}

