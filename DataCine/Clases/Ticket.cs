using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    public class Ticket
    {

        public int Id_Ticket { get; set; }
        public int Id_Reserva { get; set; }

        public Ticket()
        {
            Id_Ticket = 0;
            Id_Reserva = 0;
        }

        public Ticket(int id_Ticket, int id_Reserva)
        {
            Id_Ticket = id_Ticket;
            Id_Reserva = id_Reserva;
        }
    }
}
