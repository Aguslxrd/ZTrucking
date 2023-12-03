using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public abstract class DestinationController
    {

        public static void Create(string street, string doornumber, string corner, DateTime estimateddate, bool activeddestination)
        {
            DestinationModel destination = new DestinationModel();
            destination.StreetDestination = street;
            destination.DoorNumber = doornumber;
            destination.CornerDestination = corner;
            destination.EstimatedDate = estimateddate;
            destination.ActivedDestination = activeddestination;
            destination.Save();
        }

        public static DataTable GetAllDestinations()
        {
            DestinationModel AllDestinations = new DestinationModel();
            List<DestinationModel> destinations = AllDestinations.getAllDestinations();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Numero Destino", typeof(string));
            table.Columns.Add("Esquina Destino", typeof(string));
            table.Columns.Add("Fecha estimada", typeof(DateTime));
            table.Columns.Add("Activo", typeof(bool));

            foreach (DestinationModel destination in destinations)
            {
                DataRow row = table.NewRow();
                row["ID"] = destination.IDDestination;
                row["Calle"] = destination.StreetDestination;
                row["Numero Destino"] = destination.DoorNumber;
                row["Esquina Destino"] = destination.CornerDestination;
                row["Fecha estimada"] = destination.EstimatedDate;
                row["Activo"] = destination.ActivedDestination;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void DeleteDestination(int id)
        {
            DestinationModel destination = new DestinationModel();
            destination.IDDestination = id;
            destination.Delete();
        }

        public static void EditDestination(int id, string street, string doornumber, string corner, DateTime newDateTime, bool activeddestination)
        {
            DestinationModel destination = new DestinationModel();
            destination.IDDestination = id;

            if (destination.CheckIfDestinationExists(id))
            {
                destination.StreetDestination = street;
                destination.DoorNumber = doornumber;
                destination.CornerDestination = corner;
                destination.EstimatedDate = newDateTime;
                destination.ActivedDestination = activeddestination;
                destination.Edit();
            }
            else
            {
                throw new Exception($"El destino con ID {id} no existe en la base de datos.");
            }
        }
    }
}
