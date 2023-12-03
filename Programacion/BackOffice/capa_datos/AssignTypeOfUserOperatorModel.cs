using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignTypeOfUserOperatorModel : DataBaseControl
    {

        public int IDOperator { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO operario (id_operario) VALUES (@IDOperator)";
                this.Command.Parameters.AddWithValue("@IDOperator", this.IDOperator);
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar");
            }
        }

        public List<AssignTypeOfUserOperatorModel> GetAllOperatorsUsers()
        {
            this.Command.CommandText = $"SELECT * FROM operario";
            this.Reader = this.Command.ExecuteReader();

            List<AssignTypeOfUserOperatorModel> result = new List<AssignTypeOfUserOperatorModel>();
            while (this.Reader.Read())
            {
                AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
                user.IDOperator = Int32.Parse(this.Reader["id_operario"].ToString());
                result.Add(user);
            }
            return result;
            
        }


        public void DeleteUser()
        {
            this.Command.CommandText = $"DELETE FROM operario where id_operario = '{this.IDOperator}'";
            this.Command.ExecuteNonQuery();
        }
    }
}
