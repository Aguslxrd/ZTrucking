using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public abstract class AssignOperatorToStoreHouseController
    {
        public static void Create(int idstorehouse, int idoperator)
        {
            try
            {
                AssignOperatorToStoreHouseModel assignedOperatorToStoreHouse = new AssignOperatorToStoreHouseModel();
                assignedOperatorToStoreHouse.IDStoreHouse = idstorehouse;
                assignedOperatorToStoreHouse.IDOperator = idoperator;
                assignedOperatorToStoreHouse.Save();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static DataTable GetAllOperatorsAssignedToStoreHouses()
        {
            AssignOperatorToStoreHouseModel AssignedOperatorsTableModel = new AssignOperatorToStoreHouseModel();
            List<AssignOperatorToStoreHouseModel> operators = AssignedOperatorsTableModel.GetAllOperatorsAssignedToStoreHouses();
            DataTable table = new DataTable();
            table.Columns.Add("ID Almacen", typeof(int));
            table.Columns.Add("ID Operario", typeof(int));

            foreach (AssignOperatorToStoreHouseModel AssignedOperator in operators)
            {
                DataRow row = table.NewRow();
                row["ID Almacen"] = AssignedOperator.IDStoreHouse;
                row["ID Operario"] = AssignedOperator.IDOperator;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteAssignedOperator(int id)
        {
            AssignOperatorToStoreHouseModel AssignedOperator = new AssignOperatorToStoreHouseModel();
            AssignedOperator.IDOperator = id;
            AssignedOperator.Delete();
        }
    }
}

