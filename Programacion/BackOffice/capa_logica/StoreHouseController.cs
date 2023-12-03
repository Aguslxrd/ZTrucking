using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class StoreHouseController
    {
        public static void Create(string street, string doornumber, string corner, bool activedstorehouse)
        {
            StoreHouseModel storehouse = new StoreHouseModel();
            storehouse.Street = street;
            storehouse.DoorNumber = doornumber;
            storehouse.Corner = corner;
            storehouse.ActivatedStoreHouse = activedstorehouse;
            storehouse.Save();
        }

        public static DataTable Obtener()
        {
            StoreHouseModel StoreHouseTableModel = new StoreHouseModel();
            List<StoreHouseModel> storehouses = StoreHouseTableModel.GetAllStoreHouse();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Numero", typeof(string));
            table.Columns.Add("Esquina", typeof(string));
            table.Columns.Add("Activo", typeof(bool));

            foreach (StoreHouseModel storehouse in storehouses)
            {
                DataRow row = table.NewRow();
                row["id"] = storehouse.IDStoreHouse;
                row["Calle"] = storehouse.Street;
                row["Numero"] = storehouse.DoorNumber;
                row["Esquina"] = storehouse.Corner;
                row["Activo"] = storehouse.ActivatedStoreHouse;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void DeleteStoreHouse(int id)
        {
            StoreHouseModel storehouse = new StoreHouseModel();
            storehouse.IDStoreHouse = id;
            storehouse.Delete();
        }

        public static void UpdateStoreHouse(int id, string street, string doornumber, string corner, bool activedstorehouse)
        {
            StoreHouseModel storehouse = new StoreHouseModel();
            storehouse.IDStoreHouse = id;
            storehouse.Street = street;
            storehouse.DoorNumber = doornumber;
            storehouse.Corner = corner;
            storehouse.ActivatedStoreHouse = activedstorehouse;
            storehouse.Update();
        }

    }
}

