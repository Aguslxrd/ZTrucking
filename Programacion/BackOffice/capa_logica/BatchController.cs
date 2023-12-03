using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class BatchController
    {
        public static void Crear(string email, DateTime ShippingDate, int idshipp, string position, bool activedbatch)
        {
            try
            {
                DateTime DateCreation = DateTime.Now;
                BatchModel lot = new BatchModel();
                lot.Email = email;
                lot.ShippingDate = ShippingDate;
                lot.DateOfCreation = DateCreation;
                lot.IDShipp = idshipp;
                lot.Position = position;
                lot.ActivedBatch = activedbatch;
                lot.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Obtener()
        {
            BatchModel LotsTableModel = new BatchModel();
            List<BatchModel> lots = LotsTableModel.GetAllLots();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Fecha de creacion", typeof(DateTime));
            table.Columns.Add("Fecha de envio", typeof(DateTime));
            table.Columns.Add("ID Envio", typeof(int));
            table.Columns.Add("Posicion", typeof(string));
            table.Columns.Add("Activo", typeof(bool));

            foreach (BatchModel lot in lots)
            {
                DataRow row = table.NewRow();
                row["id"] = lot.IDBatch;
                row["Email"] = lot.Email;
                row["Fecha de creacion"] = lot.DateOfCreation;
                row["Fecha de envio"] = lot.ShippingDate;
                row["ID Envio"] = lot.IDShipp;
                row["Posicion"] = lot.Position;
                row["Activo"] = lot.ActivedBatch;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarLote(int id)
        {
            try
            {
                BatchModel lote = new BatchModel();
                lote.IDBatch = id;
                lote.DeleteLots();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
