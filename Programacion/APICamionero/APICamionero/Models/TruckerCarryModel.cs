using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class TruckerCarryModel : DatabaseConnector
    {
        [Required(ErrorMessage = "ID Camión requerido")]
        public int IDTruck { get; set; }

        [Required(ErrorMessage = "ID Lote requerido")]
        public int IDBatch { get; set; }

        public string Position { get; set; }

        public DateTime ShippmentDate { get; set; }

        public List<TruckerCarryModel> GetCarriesByTruck(int truckId)
        {
            List<TruckerCarryModel> carries = new List<TruckerCarryModel>();

            try
            {
                this.Command.CommandText = $"SELECT llevan.*, lote.posicion " +
                                           $"FROM llevan " +
                                           $"INNER JOIN lote ON llevan.id_lote = lote.id_lote " +
                                           $"WHERE llevan.id_camion = {truckId}";

                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TruckerCarryModel carry = new TruckerCarryModel
                    {
                        IDTruck = Convert.ToInt32(this.Reader["id_camion"]),
                        IDBatch = Convert.ToInt32(this.Reader["id_lote"]),
                        ShippmentDate = DateTime.Parse(this.Reader["fech_sal"].ToString()),
                        Position = this.Reader["posicion"].ToString()
                    };

                    carries.Add(carry);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return carries;
        }

    }
}
