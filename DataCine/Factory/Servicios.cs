using DataCine.AccesoDatos;
using DataCine.AccesoDatos.Interfaces;
using DataCine.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Factory
{
    public class Servicios : IServicios
    {
        private IHelperDAO dao;

        public Servicios()
        {
            dao = new HelperDAO();
        }

        public DataTable AsientosDisponibles(string NombreSP, int funcion)
        {
            return dao.AsientosDisponibles(NombreSP, funcion);
        }

        public DataTable FormasPagoMesOAnio(string NombreSP, int eleccion)
        {
            return dao.FormasPagoMesOAnio(NombreSP, eleccion);
        }

        public DataTable MostrarPorFecha(string NombreSP, DateTime fecha, DateTime fecha2)
        {
            return dao.MostrarPorFecha(NombreSP, fecha, fecha2);
        }

        public DataTable ObtenerTabla(string NombreSP)
        {
            return dao.ObtenerTabla(NombreSP);
        }

        public DataTable TicketMes(string NombreSP, string Mes)
        {
            return dao.TicketMes(NombreSP, Mes);
        }

        public DataTable Top3(string NombreSP, int anio)
        {
            return dao.Top3(NombreSP, anio);
        }

        public DataTable Vista(string consulta)
        {
            return dao.Vista(consulta);
        }

        public bool CrearComprobante(Comprobante oComprobante, string Comprobante_SP, string Detalle_SP, string Ticket_SP)
        {
            return dao.CrearComprobante(oComprobante, Comprobante_SP, Detalle_SP, Ticket_SP);
        }

        public int ObtenerCantDet(string NombreSP, string NomParam)
        {
            return dao.ObtenerCantDet(NombreSP, NomParam);
        }
    }
}
