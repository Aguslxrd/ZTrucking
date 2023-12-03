using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class ProductController
    {
        public static void Crear(int productweight,  int productvolume, string street, int doornumber, string corner, string customer, bool activeproduct)
        {
            try
            {
                ProductModel product = new ProductModel();
                product.ProductWeight = productweight;
                product.Volume = productvolume;
                product.Street = street;
                product.DoorNumber = doornumber;
                product.Corner = corner;
                product.Customer = customer;
                product.ActivatedProduct = activeproduct;
                product.Save();
            }
            catch(Exception ex)
            {
                throw new Exception("Error");
            }
        }

        public static DataTable Obtener()
        {
            ProductModel ProductTableModel = new ProductModel();
            List<ProductModel> products = ProductTableModel.GetAllProducts();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Peso", typeof(int));
            table.Columns.Add("Volumen", typeof(int));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Numero puerta", typeof(int));
            table.Columns.Add("Esquina", typeof(string));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Activo", typeof(bool));

            foreach (ProductModel product in products)
            {
                DataRow row = table.NewRow();
                row["id"] = product.IDProduct;
                row["Peso"] = product.ProductWeight;
                row["Volumen"] = product.Volume;
                row["Calle"] = product.Street;
                row["Numero puerta"] = product.DoorNumber;
                row["Esquina"] = product.Corner;
                row["Cliente"] = product.Customer;
                row["Activo"] = product.ActivatedProduct;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarProducto(int id)
        {
            ProductModel producto = new ProductModel();
            producto.IDProduct = id;
            producto.Delete();
        }
    }
}
