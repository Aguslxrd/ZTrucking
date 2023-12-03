using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public class TruckerController
    {
        public static void Create(int idtruck, int idtrucker)
        {
            TruckerModel trucker = new TruckerModel();
            trucker.IDTruck = idtruck;
            trucker.IDTrucker= idtrucker;
            trucker.Save();
        }

        public static DataTable GetAllTruckers()
        {
            TruckerModel AllTruckers = new TruckerModel();
            List<TruckerModel> truckers = AllTruckers.getAllTruckers();
            DataTable table = new DataTable();
            table.Columns.Add("Camion ID", typeof(int));
            table.Columns.Add("Conductor ID", typeof(int));

            foreach (TruckerModel truck in truckers)
            {
                DataRow row = table.NewRow();
                row["Camion ID"] = truck.IDTruck;
                row["Conductor ID"] = truck.IDTrucker;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void DeleteTrucker(int id)
        {
            TruckerModel truck = new TruckerModel();
            truck.IDTrucker = id;
            truck.Delete();
        }

    }
}
