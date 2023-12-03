using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class TrackBatchWithProductIDModel : DatabaseConnector
    {
        public int ProductId { get; private set; }
        public int BatchId { get; private set; }
        public string StreetDestination { get; private set; }
        public string DoorNumber { get; private set; }
        public string CornerDestination { get; private set; }
        public string Position { get; private set; }
        public string BatchStatus { get; private set; }
        public DateTime ShippingDate { get; private set; }

        public void GetBatchByProductId(int productId)
        {
            try
            {
                this.Command.CommandText = $"SELECT p.id_prod, l.id_lote, d.calle, d.num, t.estatus, l.posicion, l.fech_entre " +
                                                   "FROM producto AS p " +
                                                   "JOIN integra AS i ON p.id_prod = i.id_prod " +
                                                   "JOIN lote AS l ON i.id_lote = l.id_lote " +
                                                   "JOIN transporta AS t ON l.id_lote = t.id_lote " +
                                                   "JOIN destino AS d ON t.id_des = d.id_des " +
                                                   $"WHERE p.id_prod = {productId}";
                this.Reader = this.Command.ExecuteReader();

                if (this.Reader.Read())
                {
                    ProductId = Convert.ToInt32(this.Reader["id_prod"]);
                    BatchId = Convert.ToInt32(this.Reader["id_lote"]);
                    StreetDestination = this.Reader["calle"].ToString();
                    DoorNumber = this.Reader["num"].ToString();
                    BatchStatus = this.Reader["estatus"].ToString();
                    Position = this.Reader["posicion"].ToString();
                    ShippingDate = DateTime.Parse(this.Reader["fech_entre"].ToString());
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }


        }

    }
}