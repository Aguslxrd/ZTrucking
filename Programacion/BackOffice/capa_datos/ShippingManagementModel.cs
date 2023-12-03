using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class ShippingManagementModel : DataBaseControl
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public DateTime DateShipping { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO llevan(id_camion, id_lote, fech_sal) " +
                                           "VALUES(@IDTruck, @IDBatch, @DateShipping)";

                this.Command.Parameters.AddWithValue("@IDTruck", this.IDTruck);
                this.Command.Parameters.AddWithValue("@IDBatch", this.IDBatch);
                this.Command.Parameters.AddWithValue("@DateShipping", this.DateShipping);

                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
        }

        public List<ShippingManagementModel> GetAllShippings()
        {
            this.Command.CommandText = "SELECT * FROM llevan";
            this.Reader = this.Command.ExecuteReader();

            List<ShippingManagementModel> result = new List<ShippingManagementModel>();
            while (this.Reader.Read())
            {
                ShippingManagementModel shippings = new ShippingManagementModel();
                shippings.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                shippings.IDBatch = Int32.Parse(this.Reader["id_lote"].ToString());
                shippings.DateShipping = DateTime.Parse(this.Reader["fech_sal"].ToString());
                result.Add(shippings);
            }
            this.Reader.Close();
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM llevan WHERE id_lote = {this.IDBatch}";
            this.Command.ExecuteNonQuery();
        }
    }
}
