using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Personas
    {
        //Atributos
        private string nombre;
        private string apellido;
        private int identificacion;

        private static Personas instancia;

        public static Personas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Personas();
            }
            return instancia;
        }

        //Constructor
        public Personas()
        {
            Nombre = "";
            Apellido = "";
            Identificacion = 0;
        }

        public Personas(string nombre, string apellido, int identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
        }


        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Identificacion { get; set; }
    }
}
