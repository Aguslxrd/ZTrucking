using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public abstract class TravelController
    {
        public static void Create(int idstorehouse, int iddestination, string typetravel, DateTime shipmmentdate)
        {
            TravelModel travel = new TravelModel();
            travel.IDStoreHouse = idstorehouse;
            travel.IDDestination = iddestination;
            travel.TypeTravel = typetravel;
            travel.ShippmentDate = shipmmentdate;
            travel.Save();
        }

        public static DataTable GetAllTravels()
        {
            TravelModel TravelsOnTableModel = new TravelModel();
            List<TravelModel> travels = TravelsOnTableModel.GetAllTravels();
            DataTable table = new DataTable();
            table.Columns.Add("ID Almacen", typeof(int));
            table.Columns.Add("ID Destino", typeof(int));
            table.Columns.Add("Tipo Trayecto", typeof(string));
            table.Columns.Add("Fecha Trayecto", typeof(DateTime));

            foreach (TravelModel travel in travels)
            {
                DataRow row = table.NewRow();
                row["ID Almacen"] = travel.IDStoreHouse;
                row["ID Destino"] = travel.IDDestination;
                row["Tipo Trayecto"] = travel.TypeTravel;
                row["Fecha Trayecto"] = travel.ShippmentDate;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void DeleteTravel(int idstorehouse)
        {
            TravelModel travel = new TravelModel();
            travel.IDStoreHouse = idstorehouse;
            travel.Delete();
        }
    }
}
