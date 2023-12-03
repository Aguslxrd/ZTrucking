using ApiAlmacen.Controllers;
using ApiAlmacen.Controllers.Handlers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Models
{
    public class BatchModels:DatabaseConnector
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
            try {
                this.Command.CommandText = $"INSERT INTO lote (email, fech_Crea, fech_Entre, id_Des, posicion,bajalogica) VALUES " +
                $"('{this.Email.ToString()}', " +
                $"'{this.DateOfCreation.ToString("yyyy-MM-dd")}', " +
                $"'{this.ShippingDate.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"{this.IDShipp}, " +
                $"'{this.Position}', " +
                $"{this.ActivedBatch})";
                this.Command.ExecuteNonQuery(); 

            this.Command.CommandText = "SELECT last_insert_id()";
            this.IDBatch = Convert.ToInt32(this.Command.ExecuteScalar());
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BatchModels> GetAllLots()
        {
            if (this.Command == null)
            {
                throw new Exception("Error de sistema");
            }

            this.Command.CommandText = $"SELECT * FROM lote"; 
            this.Reader = this.Command.ExecuteReader();

            List<BatchModels> result = new List<BatchModels>();
            while (this.Reader.Read())
            {
                BatchModels lot = new BatchModels();
                lot.IDBatch = Int32.Parse(this.Reader["id_Lote"].ToString());
                lot.Email = this.Reader["email"].ToString();
                lot.DateOfCreation = Convert.ToDateTime(this.Reader["fech_Crea"].ToString());
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
            if (!CheckIfBatchExists(this.IDBatch))
            {
                throw new Exception($"El lote con ID {this.IDBatch} no existe, no se puede eliminar.");
            }

            this.Command.CommandText = $"DELETE FROM lote WHERE id_Lote = {this.IDBatch}";
            this.Command.ExecuteNonQuery();
        }

        public bool CheckIfBatchExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM lote WHERE id_Lote = {id}";
            object result = this.Command.ExecuteScalar();

            if(result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }
            return false;
        }

        public int GetTotalBatchOnStoreHouse()
        {
            if (this.Command == null)
            {
                this.Command = new MySqlCommand();
            }

            this.Command.CommandText = "SELECT COUNT(*) FROM lote";
            var result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int totalCount))
                {
                    return totalCount;
                }
            }

            return 0;
        }

    }
}