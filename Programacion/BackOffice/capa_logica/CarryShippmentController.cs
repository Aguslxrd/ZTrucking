using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static capa_datos.CarryShippmentModel;

namespace capa_logica
{
    public abstract class CarryShippmentController
    {
        public static void Create(int idtruck, int idbatch, int iddestination, string status)
        {
            try
            {
            CarryShippmentModel carry = new CarryShippmentModel();
            carry.IDTruck = idtruck;
            carry.IDBatch = idbatch;
            carry.IDDestination = iddestination;
            carry.ShippingStatus = status;
            carry.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static DataTable GetAllCarrys()
        {
            CarryShippmentModel CarrysTableModel = new CarryShippmentModel();
            List<CarryShippmentModel> carries = CarrysTableModel.GetAllDestinations();
            DataTable table = new DataTable();
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("ID Lote", typeof(int));
            table.Columns.Add("ID Destino", typeof(int));
            table.Columns.Add("Status", typeof(string));


            foreach (CarryShippmentModel carry in carries)
            {
                DataRow row = table.NewRow();
                row["ID Camion"] = carry.IDTruck;
                row["ID Lote"] = carry.IDBatch;
                row["ID Destino"] = carry.IDDestination;
                row["Status"] = carry.ShippingStatus; 
                table.Rows.Add(row);
            }
            return table;
        }

        public static void EditCarry(int idTruck, int idBatch, int idDestination, string status)
        {
            try
            {
                CarryShippmentModel carry = new CarryShippmentModel();
                carry.IDTruck = idTruck;
                carry.IDBatch = idBatch;
                carry.IDDestination = idDestination;
                carry.ShippingStatus = status;
                carry.Edit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteCarry(int id)
        {
            CarryShippmentModel Carry = new CarryShippmentModel();
            Carry.IDTruck = id;
            Carry.Delete();
        }


    }
}
