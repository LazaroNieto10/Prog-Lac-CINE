using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Reservas
    {
        private int cod_reserva;
        private Funciones funcion;
        private List<Butacas> butacas_reservadas;
        private Clientes cliente;
        private string estado;

        private static Reservas instancia;

        public static Reservas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Reservas();
            }
            return instancia;
        }
    }
}
