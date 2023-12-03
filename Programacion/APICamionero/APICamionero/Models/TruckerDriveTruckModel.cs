using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class TruckerDriveTruckModel : DatabaseConnector
    {
        public int IDTruck { get; set; }
        public int IDTrucker { get; set; }

        public List<TruckerDriveTruckModel> GetTrucksDrivenByTrucker(int truckerId)
        {
            List<TruckerDriveTruckModel> trucksDriven = new List<TruckerDriveTruckModel>();

            try
            {
                this.Command.CommandText = $"SELECT * FROM conduce WHERE id_camionero = {truckerId}";
                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TruckerDriveTruckModel truckDriven = new TruckerDriveTruckModel
                    {
                        IDTruck = Convert.ToInt32(this.Reader["id_camion"]),
                        IDTrucker = Convert.ToInt32(this.Reader["id_camionero"])
                    };

                    trucksDriven.Add(truckDriven);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return trucksDriven;
        }

        public TruckerDriveTruckModel GetTruckDrivenByTrucker(int truckerId, int truckId)
        {
            try
            {
                this.Command.CommandText = $"SELECT * FROM conduce WHERE id_camionero = {truckerId} AND id_camion = {truckId}";
                this.Reader = this.Command.ExecuteReader();

                if (this.Reader.Read())
                {
                    TruckerDriveTruckModel truckDriven = new TruckerDriveTruckModel
                    {
                        IDTruck = Convert.ToInt32(this.Reader["id_camion"]),
                        IDTrucker = Convert.ToInt32(this.Reader["id_camionero"])
                    };

                    this.Reader.Close();
                    return truckDriven;
                }

                this.Reader.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

    }
}
