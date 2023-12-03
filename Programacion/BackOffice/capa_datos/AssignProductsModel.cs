using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignProductsModel : DataBaseControl
    {
        public int IDProduct { get; set; }
        public int IDBatch { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO integra (id_prod, id_lote) VALUES (@IDProduct, @IDBatch)";
                this.Command.Parameters.AddWithValue("@IDProduct", this.IDProduct);
                this.Command.Parameters.AddWithValue("@IDBatch", this.IDBatch);
                this.Command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    throw new InvalidOperationException("No se puede insertar un registro duplicado.");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<AssignProductsModel> TodosLosItems()
        {
            this.Command.CommandText = "SELECT * FROM integra";
            this.Reader = this.Command.ExecuteReader();

            List<AssignProductsModel> result = new List<AssignProductsModel>();
            while (this.Reader.Read())
            {
                AssignProductsModel assignedProduct = new AssignProductsModel();
                assignedProduct.IDBatch = Int32.Parse(this.Reader["id_lote"].ToString());
                assignedProduct.IDProduct = Int32.Parse(this.Reader["id_prod"].ToString());
                result.Add(assignedProduct);
            }
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM integra WHERE id_lote = {this.IDBatch}";
            this.Command.ExecuteNonQuery();
        }

    }
}
