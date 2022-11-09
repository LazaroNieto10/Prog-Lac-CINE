using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Clientes : Personas
    {
        //Atributos
        private int puntos;
    
        //Constructores
        public Clientes() : base()
        {
            Puntos = 0;
        }

        public Clientes(string nombre, string apellido, int identificacion, int puntos) : base(nombre, apellido, identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Puntos = puntos;
        }


        //Propiedades
        public int Puntos { get; set; }


        //Metodos
        public int Actualizar_puntos (int cantidad)
        {
            this.Puntos += cantidad;
            return this.Puntos;
        }

    }
}
