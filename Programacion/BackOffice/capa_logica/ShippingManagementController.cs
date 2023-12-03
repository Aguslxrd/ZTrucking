using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public abstract class ShippingManagementController
    {
        public static void Create(int idtruck, int idbatch, DateTime dateofshipping)
        {
            try
            {

            ShippingManagementModel Shippings = new ShippingManagementModel();
            Shippings.IDTruck = idtruck;
            Shippings.IDBatch = idbatch;
            Shippings.DateShipping = dateofshipping;
            Shippings.Save();
            }catch (Exception ex)
            {
                throw new Exception("Error");
            }

        }

        public static DataTable GetAllShippings()
        {
            ShippingManagementModel ShippingsTableModel = new ShippingManagementModel();
            List<ShippingManagementModel> Shippings = ShippingsTableModel.GetAllShippings();
            DataTable table = new DataTable();
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("ID Lote", typeof(int));
            table.Columns.Add("Fecha Salida", typeof(DateTime));

            foreach (ShippingManagementModel shipping in Shippings)
            {
                DataRow row = table.NewRow();
                row["ID Camion"] = shipping.IDTruck;
                row["ID Lote"] = shipping.IDBatch;
                row["Fecha Salida"] = shipping.DateShipping;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteShipp(int id)
        {
            ShippingManagementModel Shipping = new ShippingManagementModel();
            Shipping.IDBatch = id;
            Shipping.Delete();
        }
    }
}

