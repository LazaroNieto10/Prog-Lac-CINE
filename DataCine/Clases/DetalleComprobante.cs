using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCine.AccesoDatos;

namespace DataCine.Clases
{
    public class DetalleComprobante
    {

        public int Id_detalle { get; set; }
        public double Precio { get; set; }
        public int Id_Promo { get; set; }
        public Ticket ticket { get; set; }
        public int Cantidad { get; set; } //nuevo

        public DetalleComprobante()
        {
            Id_detalle = 0;
            Precio = 0;
            Id_Promo = 0;
            ticket = new Ticket();
            Cantidad = 0;
        }

        public DetalleComprobante(int id_detalle, double precio, int id_Promo, Ticket ticket, int cantidad)
        {
            Id_detalle = id_detalle;
            Precio = precio;
            Id_Promo = id_Promo;
            this.ticket = ticket;
            Cantidad = cantidad;
        }

        public double CalcularMonto(string NombreSP, string NomParam)
        {
            double total = 0;
            total = Precio * HelperDAO.ObtenerInstancia().ObtenerCantDet(NombreSP,NomParam);
            //total = Precio * Cantidad

            return total;
        }
    }
}
