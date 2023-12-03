using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class TruckModel : DataBaseControl
    {
        public int IDTruck { get; set; }
        public int TruckWeight { get; set; }
        public int TruckVolume { get; set; }
        public bool ActivedTruck { get; set; }

        public void Save()
        {
            this.Command.CommandText = "INSERT INTO camion(peso_camion, volumen_camion, bajalogica) " +
                                       "VALUES(@TruckWeight, @TruckVolume, @ActivedTruck)";

            this.Command.Parameters.AddWithValue("@TruckWeight", this.TruckWeight);
            this.Command.Parameters.AddWithValue("@TruckVolume", this.TruckVolume);
            this.Command.Parameters.AddWithValue("@ActivedTruck", this.ActivedTruck);

            this.Command.ExecuteNonQuery();
        }

        public List<TruckModel> getAllTrucks()
        {
            this.Command.CommandText = $"SELECT * FROM camion";
            this.Reader = this.Command.ExecuteReader();
            List<TruckModel> result = new List<TruckModel>();
            while (this.Reader.Read())
            {
                TruckModel truck = new TruckModel();
                truck.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                truck.TruckWeight = Int32.Parse(this.Reader["peso_camion"].ToString());
                truck.TruckVolume = Int32.Parse(this.Reader["volumen_camion"].ToString());
                truck.ActivedTruck = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
                result.Add(truck);
            }
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM camion WHERE id_camion = {this.IDTruck}";
            this.Command.ExecuteNonQuery();
        }

        public bool CheckIfTruckExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM camion WHERE id_camion = {id}";
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

        public void Edit()
        {
            bool truckExists = CheckIfTruckExists(this.IDTruck);

            if (truckExists)
            {
                this.Command.CommandText = "UPDATE camion SET " +
                                           "peso_camion = @TruckWeight, " +
                                           "volumen_camion = @TruckVolume, " +
                                           "bajalogica = @ActivedTruck " +
                                           "WHERE id_camion = @IDTruck";

                this.Command.Parameters.AddWithValue("@TruckWeight", this.TruckWeight);
                this.Command.Parameters.AddWithValue("@TruckVolume", this.TruckVolume);
                this.Command.Parameters.AddWithValue("@ActivedTruck", this.ActivedTruck);
                this.Command.Parameters.AddWithValue("@IDTruck", this.IDTruck);

                this.Command.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("Error");
            }
        }

    }
}
