using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataCine.AccesoDatos.Interfaces;
using DataCine.Clases;

namespace DataCine.AccesoDatos
{
    public class HelperDAO : IHelperDAO
    {

        private static HelperDAO instancia;
        private SqlConnection cnn = new SqlConnection(@""); //falta cadena de conexión

 
        public static HelperDAO ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public DataTable ObtenerTabla(string NombreSP)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;
            tabla.Load(comando.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public DataTable TicketMes(string NombreSP, string Mes)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter param = new SqlParameter();
            param.DbType = DbType.String;
            param.ParameterName = "@mes";
            param.Value = Mes;
            param.Direction = ParameterDirection.Input;

            comando.Parameters.Add(param);

            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public DataTable Top3(string NombreSP, int anio)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter param = new SqlParameter();
            param.DbType = DbType.String;
            param.ParameterName = "@anio";
            param.Value = anio;
            param.Direction = ParameterDirection.Input;

            comando.Parameters.Add(param);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public DataTable Vista(string consulta) //cambiar nombre
        {
            cnn.Open();
            DataTable tabla = new DataTable();

            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        } 

        public DataTable FormasPagoMesOAnio(string NombreSP, int eleccion)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = NombreSP;

            SqlParameter parametro = new SqlParameter();
            parametro.DbType = DbType.Int32;
            parametro.ParameterName = "@periodo";
            parametro.Value = eleccion;
            parametro.Direction = ParameterDirection.Input;

            comando.Parameters.Add(parametro);

            tabla.Load(comando.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public DataTable AsientosDisponibles(string NombreSP, int funcion)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter parametro = new SqlParameter();
            parametro.DbType = DbType.Int32;
            parametro.ParameterName = "@funcion";
            parametro.Value = funcion;
            parametro.Direction = ParameterDirection.Input;

            comando.Parameters.Add(parametro);

            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        // crear nuevo sp
        public DataTable MostrarPorFecha(string NombreSP, DateTime fecha, DateTime fecha2)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter parametro = new SqlParameter();
            parametro.DbType = DbType.DateTime;
            parametro.ParameterName = "@fecha1";
            parametro.Value = fecha;
            parametro.Direction = ParameterDirection.Input;

            SqlParameter parametro2 = new SqlParameter();
            parametro.DbType = DbType.DateTime;
            parametro.ParameterName = "@fecha2";
            parametro.Value = fecha2;
            parametro.Direction = ParameterDirection.Input;

            comando.Parameters.Add(parametro);
            comando.Parameters.Add(parametro2); //?
            tabla.Load(comando.ExecuteReader());
            return tabla;
        }

        public bool CrearComprobante(Comprobante oComprobante, string Comprobante_SP, string Detalle_SP, string Ticket_SP)
        {
            SqlTransaction t = null;
            bool valido = true;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = Comprobante_SP;
                comando.Transaction = t;

                comando.Parameters.AddWithValue("@forma_pago", oComprobante.F_Pago);
                comando.Parameters.AddWithValue("@id_cliente", oComprobante.Id_Cliente);
                comando.Parameters.AddWithValue("@cod_retiro", oComprobante.Cod_Retiro);
                comando.Parameters.AddWithValue("@fecha", oComprobante.Fecha.ToString("dd/MM/yyyy"));

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro_comprobante";
                param.Direction = ParameterDirection.Output;
                param.DbType = DbType.Int32;

                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                int id;

                id = (int)param.Value;
                foreach (DetalleComprobante det in oComprobante.L_Detalles)
                {
                    SqlCommand comando2 = new SqlCommand();
                    comando.Connection = cnn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = Detalle_SP;
                    comando.Transaction = t;
                    comando.Parameters.AddWithValue("@nro_comprobante", id);
                    comando.Parameters.AddWithValue("@id_detalle", det.Id_detalle); //está mal, hacer sp para sacar el nro
                    comando.Parameters.AddWithValue("@precio", det.Precio);
                    comando.Parameters.AddWithValue("@id_promo", det.Id_Promo);
                    //comando.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    comando.ExecuteNonQuery();

                    //añadir ticket
                    SqlCommand comando3 = new SqlCommand();
                    comando3.Connection = cnn;
                    comando3.CommandType = CommandType.StoredProcedure;
                    comando3.CommandText = Ticket_SP;
                    comando3.Parameters.AddWithValue("@nro_comprobante", id);
                    comando3.Parameters.AddWithValue("@id_detalle", det.Id_detalle); //hacer sp para obtener el nro
                    comando3.Parameters.AddWithValue("@id_reserva", det.ticket.Id_Reserva);
                    comando3.ExecuteNonQuery();
                }

                t.Commit();
                cnn.Close();
            }
            catch (Exception)
            {
                t.Rollback();
                cnn.Close();
                valido = false;
                return valido;
            }

            return valido;
        }

        public int ObtenerCantDet(string NombreSP, string NomParam)
        {
            cnn.Open();
            int cantidad = 0;
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            SqlParameter param = new SqlParameter();
            param.ParameterName = NomParam;
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            cnn.Close();
            cantidad = (int)param.Value;

            return cantidad;
        }
    }

    
}
