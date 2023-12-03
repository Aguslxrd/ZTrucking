using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class TravelModel : DatabaseConnector
    {
        [Required(ErrorMessage = "ID Almacén requerido")]
        public int IDStoreHouse { get; set; }

        [Required(ErrorMessage = "ID Destino requerido")]
        public int IDDestination { get; set; }

        [Required(ErrorMessage = "Tipo de recorrido requerido")]
        [StringLength(50, ErrorMessage = "Error en tipo de dato.")]
        public string TypeTravel { get; set; }

        public DateTime ShippmentDate { get; set; }

        public List<TravelModel> GetTravelsByStoreHouse(int storeHouseId)
        {
            List<TravelModel> travels = new List<TravelModel>();

            try
            {
                this.Command.CommandText = $"SELECT * FROM recorrido WHERE id_alma = {storeHouseId}";
                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TravelModel travel = new TravelModel
                    {
                        IDStoreHouse = Convert.ToInt32(this.Reader["id_alma"]),
                        IDDestination = Convert.ToInt32(this.Reader["id_des"]),
                        TypeTravel = this.Reader["tipo_trayecto"].ToString(),
                        ShippmentDate = DateTime.Parse(this.Reader["fech_trayecto"].ToString())
                    };

                    travels.Add(travel);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return travels;
        }

        public List<TravelModel> GetTravelsByDestination(int destinationId)
        {
            List<TravelModel> travels = new List<TravelModel>();

            try
            {
                this.Command.CommandText = $"SELECT * FROM recorrido WHERE id_des = {destinationId}";
                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TravelModel travel = new TravelModel
                    {
                        IDStoreHouse = Convert.ToInt32(this.Reader["id_alma"]),
                        IDDestination = Convert.ToInt32(this.Reader["id_des"]),
                        TypeTravel = this.Reader["tipo_trayecto"].ToString(),
                        ShippmentDate = DateTime.Parse(this.Reader["fech_trayecto"].ToString())
                    };

                    travels.Add(travel);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            this.Connection.Close();
            return travels;
        }
    }
}
