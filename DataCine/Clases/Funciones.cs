using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Funciones
    {
        //Atrubitos
        private int id_funcion;
        private DateTime fecha;
        private TimeSpan horario;
        private Peliculas pelicula;
        private Salas sala;
        private static Funciones instancia;
        
        public static Funciones ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Funciones();
            }
            return instancia;
        }

        //Constructores
        public Funciones()
        {
            Id_funcion = 0;
            Fecha = DateTime.MinValue;
            Horario = DateTime.Now.TimeOfDay ;
        }

        public Funciones(int id_funcion, DateTime fecha, TimeSpan horario, Peliculas pelicula, Salas sala)
        {
            Id_funcion = id_funcion;
            Fecha = fecha;
            Horario = horario;
            Pelicula = pelicula;
            Sala = sala;
        }




        //Propiedades
        public int Id_funcion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }
        public Peliculas Pelicula { get; set; }
        public Salas Sala { get; set; }

    }
}
