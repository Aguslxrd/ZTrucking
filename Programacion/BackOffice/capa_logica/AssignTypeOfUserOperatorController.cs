using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class AssignTypeOfUserOperatorController
    {

        public static void Crear(int id)
        {
            try
            {

            AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
            user.IDOperator = id;
            user.Save();
            }catch(Exception ex)
            {
                throw new Exception("Error");
            }
        }

        public static DataTable Obtener()
        {
            AssignTypeOfUserOperatorModel UserTableModel = new AssignTypeOfUserOperatorModel();
            List<AssignTypeOfUserOperatorModel> users = UserTableModel.GetAllOperatorsUsers();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));


            foreach (AssignTypeOfUserOperatorModel user in users)
            {
                DataRow row = table.NewRow();
                row["ID"] = user.IDOperator;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(int id)
        {
            AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
            user.IDOperator = id;
            user.DeleteUser();
        }
    }
}
