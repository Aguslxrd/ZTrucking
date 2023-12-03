using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignTypeOfUserTruckerModel : DataBaseControl
    {
        public int IDTrucker { get; set; }

        public void Save()
        {
            this.Command.CommandText = "INSERT INTO camionero (id_camionero) VALUES (@IDTrucker)";
            this.Command.Parameters.AddWithValue("@IDTrucker", this.IDTrucker);
            this.Command.ExecuteNonQuery();
        }

        public List<AssignTypeOfUserTruckerModel> GetAllTruckersUsers()
        {
            this.Command.CommandText = $"SELECT * FROM camionero";
            this.Reader = this.Command.ExecuteReader();

            List<AssignTypeOfUserTruckerModel> result = new List<AssignTypeOfUserTruckerModel>();
            while (this.Reader.Read())
            {
                AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
                user.IDTrucker = Int32.Parse(this.Reader["id_camionero"].ToString());
                result.Add(user);
            }
            return result;
        }


        public void DeleteUser()
        {
            try
            {
                this.Command.CommandText = $"DELETE FROM camionero where id_camionero = '{this.IDTrucker}'";
                this.Command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
