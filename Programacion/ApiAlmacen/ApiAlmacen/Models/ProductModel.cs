using ApiAlmacen.Controllers;
using ApiAlmacen.Controllers.Handlers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Models
{
    public class ProductModel : DatabaseConnector
    {

        public int IDProduct { get; set; }
        [Required]
        public int ProductWeight { get; set; }
        [Required]
        public bool ActivatedProduct { get; set; }
        [Required]
        public int Volume { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int DoorNumber { get; set; }
        [Required]
        public string Corner { get; set; }
        [Required]
        public string Customer { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO producto(peso_producto, bajalogica, volumen_producto, calle, num, esq, cliente) VALUES(" +
               $"{this.ProductWeight}, " +
               $"{this.ActivatedProduct}, " +
               $"{this.Volume}," +
               $"'{this.Street}'," +
               $"{this.DoorNumber}," +
               $"'{this.Corner}'," +
               $"'{this.Customer}')";
            this.Command.ExecuteNonQuery();
            
            this.Command.CommandText = "SELECT LAST_INSERT_ID()";
            this.IDProduct = Convert.ToInt32(this.Command.ExecuteScalar());
        }


        public bool CheckIfProductExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM producto WHERE id_Prod = {id}";
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

        public void Edit()
        {
            
            bool productExists = CheckIfProductExists(this.IDProduct);

            if (productExists == true)
            {
                this.Command.CommandText = $"UPDATE producto SET " +
                    $"peso_producto = {this.ProductWeight}, " +
                    $"bajalogica = {this.ActivatedProduct}, " +
                    $"volumen_producto = {this.Volume}, " +
                    $"calle = '{this.Street}', " +
                    $"num = {this.DoorNumber}, " +
                    $"esq = '{this.Corner}', " +
                    $"cliente = '{this.Customer}'" +
                    $"WHERE id_prod = {this.IDProduct}";
                this.Command.ExecuteNonQuery();
            }
            else
            {
                throw new ProductNotFoundException(this.IDProduct);
            }
        }


        public List<ProductModel> GetAllProducts()
        {
            if (this.Command == null)
            {
                this.Command = new MySqlCommand();
            }

            this.Command.CommandText = "SELECT * FROM producto";
            this.Reader = this.Command.ExecuteReader();

            List<ProductModel> result = new List<ProductModel>();
            while (this.Reader.Read())
            {
                ProductModel product = new ProductModel();
                product.IDProduct = Int32.Parse(this.Reader["id_prod"].ToString());
                product.ProductWeight = Int32.Parse(this.Reader["peso_producto"].ToString());
                product.ActivatedProduct = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
                product.Volume = Int32.Parse(this.Reader["volumen_producto"].ToString());
                product.Street = this.Reader["calle"].ToString();
                product.DoorNumber = Int32.Parse(this.Reader["num"].ToString());
                product.Corner = this.Reader["esq"].ToString();
                product.Customer = this.Reader["cliente"].ToString();
                result.Add(product);
            }
            this.Reader.Close();
            return result;
        }

        public void DeleteProduct()
        {
            if(this.Command == null)
            {
                throw new Exception("Command error");
            }
            this.Command.CommandText = $"DELETE FROM producto WHERE id_prod = {this.IDProduct}";
            this.Command.ExecuteNonQuery();
        }

        public int GetTotalProductOnStoreHouse()
        {
            if (this.Command == null)
            {
                this.Command = new MySqlCommand();
            }

            this.Command.CommandText = "SELECT COUNT(*) FROM producto";
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