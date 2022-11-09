using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    public class Comprobante
    {

        public int Nro { get; set; }
        public int F_Pago { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Cod_Retiro { get; set; }
        public List<DetalleComprobante> L_Detalles { get; set; }

        public Comprobante()
        {
            Nro = 0;
            F_Pago = 0;
            Id_Cliente = 0;
            Fecha = DateTime.Now;
            Cod_Retiro = 0;
            L_Detalles = new List<DetalleComprobante>();
        }

        public Comprobante(int nro, int f_Pago, int id_Cliente, DateTime fecha, int cod_Retiro, List<DetalleComprobante> l_Detalles)
        {
            Nro = nro;
            F_Pago = f_Pago;
            Id_Cliente = id_Cliente;
            Fecha = fecha;
            Cod_Retiro = cod_Retiro;
            L_Detalles = l_Detalles;
        }

        public void AgregarDetalles(DetalleComprobante detalle)
        {
            L_Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            L_Detalles.RemoveAt(indice);
        }
    }
}
