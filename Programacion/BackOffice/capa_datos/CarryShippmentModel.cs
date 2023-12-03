using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class CarryShippmentModel : DataBaseControl
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public int IDDestination { get; set; }
        public string ShippingStatus { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO transporta(id_camion, id_lote, id_des, estatus) " +
                                           "VALUES(@IDTruck, @IDBatch, @IDDestination, @ShippingStatus)";

                this.Command.Parameters.AddWithValue("@IDTruck", this.IDTruck);
                this.Command.Parameters.AddWithValue("@IDBatch", this.IDBatch);
                this.Command.Parameters.AddWithValue("@IDDestination", this.IDDestination);
                this.Command.Parameters.AddWithValue("@ShippingStatus", this.ShippingStatus);

                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex);
            }
        }

        public List<CarryShippmentModel> GetAllDestinations()
        {
            this.Command.CommandText = "SELECT * FROM transporta";
            this.Reader = this.Command.ExecuteReader();

            List<CarryShippmentModel> result = new List<CarryShippmentModel>();
            while (this.Reader.Read())
            {
                CarryShippmentModel destinations = new CarryShippmentModel();
                destinations.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                destinations.IDBatch = Int32.Parse(this.Reader["id_lote"].ToString());
                destinations.IDDestination = Int32.Parse(this.Reader["id_des"].ToString());
                destinations.ShippingStatus = this.Reader["estatus"].ToString();
                result.Add(destinations);
            }
            this.Reader.Close();
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM transporta WHERE id_camion = {this.IDTruck}";
            this.Command.ExecuteNonQuery();
        }

        public void Edit()
        {
            bool truckExists = CheckIfTruckExists(this.IDTruck);

            if (truckExists)
            {
                this.Command.CommandText = "UPDATE transporta SET " +
                                           "id_lote = @IDBatch, " +
                                           "id_des = @IDDestination, " +
                                           "estatus = @ShippingStatus " +
                                           "WHERE id_camion = @IDTruck";

                this.Command.Parameters.AddWithValue("@IDBatch", this.IDBatch);
                this.Command.Parameters.AddWithValue("@IDDestination", this.IDDestination);
                this.Command.Parameters.AddWithValue("@ShippingStatus", this.ShippingStatus);
                this.Command.Parameters.AddWithValue("@IDTruck", this.IDTruck);

                this.Command.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("Error: El camión no existe.");
            }
        }

        private bool CheckIfTruckExists(int truckId)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM transporta WHERE id_camion = {truckId}";
            int count = Convert.ToInt32(this.Command.ExecuteScalar());
            return count > 0;
        }

    }
}
