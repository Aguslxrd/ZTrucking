using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class TruckerModel : DataBaseControl
    {
        public int IDTruck { get; set; }
        public int IDTrucker { get; set; }

        public void Save()
        {
            if (!DoesTruckerExist(IDTrucker))
            {
                throw new Exception("El conductor no existe.");
            }

            this.Command.CommandText = "INSERT INTO conduce(id_camion, id_camionero) VALUES(@IDTruck, @IDTrucker)";

            this.Command.Parameters.AddWithValue("@IDTruck", this.IDTruck);
            this.Command.Parameters.AddWithValue("@IDTrucker", this.IDTrucker);

            this.Command.ExecuteNonQuery();
        }

        private bool DoesTruckerExist(int idTrucker)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM camionero WHERE id_camionero = {idTrucker}";
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


        public List<TruckerModel> getAllTruckers()
        {
            this.Command.CommandText = $"SELECT * FROM conduce";
            this.Reader = this.Command.ExecuteReader();
            List<TruckerModel> result = new List<TruckerModel>();
            while (this.Reader.Read())
            {
                TruckerModel trucker = new TruckerModel();
                trucker.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                trucker.IDTrucker = Int32.Parse(this.Reader["id_camionero"].ToString());
                result.Add(trucker);
            }
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM conduce WHERE id_camionero = {this.IDTrucker}";
            this.Command.ExecuteNonQuery();
        }

        
    }
}
