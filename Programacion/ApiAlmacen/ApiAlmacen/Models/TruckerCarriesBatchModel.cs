using ApiAlmacen.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Models
{
    public class TruckerCarriesBatchModel : DatabaseConnector
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public DateTime ShippDate { get; set; }


        public void Save()
        {
            try
            {
                this.Command.CommandText = $"INSERT INTO llevan (id_camion, id_Lote, fech_sal) VALUES (" +
                    $"{this.IDTruck}, " +
                    $"{this.IDBatch}, " +
                    $"'{this.ShippDate.ToString("yyyy-MM-dd HH:mm:ss")}')";
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCarries()
        {
            this.Command.CommandText = $"DELETE FROM llevan WHERE id_camion = {this.IDTruck}";
            this.Command.ExecuteNonQuery();
        }

        public List<TruckerCarriesBatchModel> GetAllCarries()
        {
            this.Command.CommandText = "SELECT * FROM llevan";
            this.Reader = this.Command.ExecuteReader();

            List<TruckerCarriesBatchModel> result = new List<TruckerCarriesBatchModel>();
            while (this.Reader.Read())
            {
                TruckerCarriesBatchModel carrie = new TruckerCarriesBatchModel();
                carrie.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                carrie.IDBatch = Int32.Parse(this.Reader["id_lote"].ToString());
                carrie.ShippDate = Convert.ToDateTime(this.Reader["fech_sal"].ToString());
                result.Add(carrie);
            }
            this.Reader.Close();
            return result;
        }
    }
}
