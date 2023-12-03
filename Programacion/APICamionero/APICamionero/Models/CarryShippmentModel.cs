using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APICamionero.Models
{
    public class CarryShippmentModel : DatabaseConnector
    {
        [Required(ErrorMessage = "ID Camión requerido")]
        public int IDTruck { get; set; }

        [Required(ErrorMessage = "ID Lote requerido")]
        public int IDBatch { get; set; }

        [Required(ErrorMessage = "ID Destino requerido")]
        public int IDDestination { get; set; }

        [Required(ErrorMessage = "Estado de transporte requerido")]
        [StringLength(50, ErrorMessage = "Error en tipo de status.")]
        public string ShippingStatus { get; set; }

        public string Position { get; set; }

        public enum ShippingStatusEnum
        {
            Entregado,
            EnCamino,
            Retrasado,
            NoEnviado
        }

        public bool Edit(int idCamionero)
        {
            try
            {
                if (!Exists(this.IDTruck, this.IDDestination, this.IDBatch))
                {
                    throw new Exception("El registro no existe.");
                }

                if (!IsAssignedToCamionero(idCamionero))
                {
                    throw new Exception("No tienes permiso para editar este envío.");
                }

                if (!Enum.IsDefined(typeof(ShippingStatusEnum), this.ShippingStatus))
                {
                    throw new Exception("Estado de envío no válido. " + this.ShippingStatus);
                }

                this.Command.CommandText = $"UPDATE transporta SET " +
                   $"estatus = '{this.ShippingStatus}' " +
                   $"WHERE id_camion = {this.IDTruck} AND id_des = {this.IDDestination} AND id_lote = {this.IDBatch}";

                this.Command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


        private bool Exists(int idCamion, int idDestino, int idLote)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM transporta WHERE id_camion = {idCamion} AND id_des = {idDestino} AND id_lote = {idLote}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }



        public List<CarryShippmentModel> GetAssignedToCamionero(int idCamionero)
        {
            this.Command.CommandText = $"SELECT transporta.*, lote.posicion " +
                                       $"FROM transporta " +
                                       $"INNER JOIN lote ON transporta.id_lote = lote.id_lote " +
                                       $"WHERE transporta.id_camion = {idCamionero}";

            this.Reader = this.Command.ExecuteReader();

            List<CarryShippmentModel> result = new List<CarryShippmentModel>();
            while (this.Reader.Read())
            {
                CarryShippmentModel carryshipment = new CarryShippmentModel
                {
                    IDTruck = Int32.Parse(this.Reader["id_camion"].ToString()),
                    IDBatch = Int32.Parse(this.Reader["id_lote"].ToString()),
                    IDDestination = Int32.Parse(this.Reader["id_des"].ToString()),
                    Position = this.Reader["posicion"].ToString(),
                    ShippingStatus = this.Reader["estatus"].ToString()
                };
                result.Add(carryshipment);
            }

            this.Reader.Close();
            return result;
        }



        private bool Exists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM transporta WHERE id_camion = {id}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }

        private bool IsAssignedToCamionero(int idCamionero)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM transporta WHERE id_camion = {this.IDTruck} AND id_lote = {this.IDBatch}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }

        public CarryShippmentModel GetOne(int id)
        {
            this.Command.CommandText = $"SELECT transporta.*, lote.posicion " +
                                       $"FROM transporta " +
                                       $"INNER JOIN lote ON transporta.id_lote = lote.id_lote " +
                                       $"WHERE transporta.id_camion = {id}";

            this.Reader = this.Command.ExecuteReader();

            if (this.Reader.Read())
            {
                CarryShippmentModel carryshipment = new CarryShippmentModel
                {
                    IDTruck = Int32.Parse(this.Reader["id_camion"].ToString()),
                    IDBatch = Int32.Parse(this.Reader["id_lote"].ToString()),
                    IDDestination = Int32.Parse(this.Reader["id_des"].ToString()),
                    Position = this.Reader["posicion"].ToString(),
                    ShippingStatus = this.Reader["estatus"].ToString()
                };
                this.Reader.Close();
                return carryshipment;
            }

            this.Reader.Close();
            return null;
        }


    }
}
