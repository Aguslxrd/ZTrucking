using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capa_datos
{
    public class BatchModel : DataBaseControl
    {
        public int IDBatch { get; set; }
        public string Email { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime ShippingDate { get; set; }
        public int IDShipp { get; set; }
        public string Position { get; set; }
        public bool ActivedBatch { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = "INSERT INTO lote (email, fech_Crea, fech_Entre, id_Des, posicion, bajalogica) " +
                                           "VALUES (@Email, @DateOfCreation, @ShippingDate, @IDShipp, @Position, @ActivedBatch)";

                this.Command.Parameters.AddWithValue("@Email", this.Email.ToString());
                this.Command.Parameters.AddWithValue("@DateOfCreation", this.DateOfCreation.ToString("yyyy-MM-dd HH:mm:ss"));
                this.Command.Parameters.AddWithValue("@ShippingDate", this.ShippingDate.ToString("yyyy-MM-dd HH:mm:ss"));
                this.Command.Parameters.AddWithValue("@IDShipp", this.IDShipp);
                this.Command.Parameters.AddWithValue("@Position", this.Position);
                this.Command.Parameters.AddWithValue("@ActivedBatch", this.ActivedBatch);

                this.Command.ExecuteNonQuery();

                this.Command.CommandText = "SELECT last_insert_id()";
                this.IDBatch = Convert.ToInt32(this.Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<BatchModel> GetAllLots()
        {
            this.Command.CommandText = $"SELECT * FROM lote";
            this.Reader = this.Command.ExecuteReader();

            List<BatchModel> result = new List<BatchModel>();
            while (this.Reader.Read())
            {
                BatchModel lot = new BatchModel();
                lot.IDBatch = Int32.Parse(this.Reader["id_Lote"].ToString());
                lot.Email = this.Reader["email"].ToString();
                lot.DateOfCreation = DateTime.Parse(this.Reader["fech_Crea"].ToString());
                lot.ShippingDate = DateTime.Parse(this.Reader["fech_Entre"].ToString());
                lot.IDShipp = Int32.Parse(this.Reader["id_Des"].ToString());
                lot.Position = this.Reader["posicion"].ToString();
                lot.ActivedBatch = Convert.ToBoolean(this.Reader["bajalogica"]);
                result.Add(lot);
            }
            this.Reader.Close();
            return result;
        }
        public void DeleteLots()
        {
            try
            {
                this.Command.CommandText = $"SELECT COUNT(*) FROM llevan WHERE id_lote = {this.IDBatch}";
                int carryCount = Convert.ToInt32(this.Command.ExecuteScalar());

                if (carryCount > 0)
                {
                    throw new Exception("Error, lote vinculado a un envio.");
                }

                this.Command.CommandText = $"DELETE FROM lote WHERE id_Lote = {this.IDBatch}";
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }


        public bool CheckIfBatchExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM lote WHERE id_Lote = {id}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }
            return false;
        }

    }
}
