using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataCine.Clases;

namespace DataCine.AccesoDatos.Interfaces
{
    public interface IHelperDAO
    {
        DataTable ObtenerTabla(string NombreSP);
        DataTable TicketMes(string NombreSP, string Mes);
        DataTable Top3(string NombreSP, int anio);
        DataTable Vista(string consulta);
        DataTable FormasPagoMesOAnio(string NombreSP, int eleccion);
        DataTable AsientosDisponibles(string NombreSP, int funcion);
        DataTable MostrarPorFecha(string NombreSP, DateTime fecha, DateTime fecha2);
        bool CrearComprobante(Comprobante oComprobante, string Comprobante_SP, string Detalle_SP, string Ticket_SP);
        int ObtenerCantDet(string NombreSP, string NomParam);
    }
}
