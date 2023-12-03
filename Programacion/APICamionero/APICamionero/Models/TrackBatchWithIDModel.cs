using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class TrackBatchWithIDModel : DatabaseConnector
    {
        public int BatchId { get; private set; }
        public string StreetDestination { get; private set; }
        public string DoorNumber { get; private set; }
        public DateTime ShippmentDate { get; private set; }
        public string BatchStatus { get; private set; }
        public string Position { get; private set; }

        public void GetDestinationAndStatusByLoteId(int loteId)
        {
            try
            {
                this.Command.CommandText = $"SELECT l.id_lote, d.calle, d.num, l.posicion, l.fech_entre, t.estatus " +
                                           "FROM lote AS l " +
                                           "JOIN transporta AS t ON l.id_lote = t.id_lote " +
                                           "JOIN destino AS d ON t.id_des = d.id_des " +
                                           $"WHERE l.id_lote = {loteId}";
                this.Reader = this.Command.ExecuteReader();

                if (this.Reader.Read())
                {
                    BatchId = Convert.ToInt32(this.Reader["id_lote"]);
                    StreetDestination = this.Reader["calle"].ToString();
                    DoorNumber = this.Reader["num"].ToString();
                    ShippmentDate = DateTime.Parse(this.Reader["fech_entre"].ToString());
                    BatchStatus = this.Reader["estatus"].ToString();
                    Position = this.Reader["posicion"].ToString();
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
