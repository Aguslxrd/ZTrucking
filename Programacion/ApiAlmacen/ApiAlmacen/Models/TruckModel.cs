using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Models
{
    public class TruckModel : DatabaseConnector
    {

        public int TruckID { get; set; }
        public int TruckWeight { get; set; }
        public int TruckVolume { get; set; }

        public List<TruckModel> GetAllTrucks()
        {
            if (this.Command == null)
            {
                this.Command = new MySqlCommand();
            }

            this.Command.CommandText = "SELECT * FROM camion where bajalogica = 1";
            this.Reader = this.Command.ExecuteReader();

            List<TruckModel> result = new List<TruckModel>();
            while (this.Reader.Read())
            {
                TruckModel truck = new TruckModel();
                truck.TruckID = Int32.Parse(this.Reader["id_camion"].ToString());
                truck.TruckVolume = Int32.Parse(this.Reader["peso_camion"].ToString());
                truck.TruckWeight = Int32.Parse(this.Reader["volumen_camion"].ToString());
                result.Add(truck);
            }
            this.Reader.Close();
            return result;
        }

    }
}