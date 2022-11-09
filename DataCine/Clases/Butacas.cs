using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Butacas
    {
        
        //Atributos
        private string fila;
        private int numero;
        private string estado;

        private static Butacas instancia;

        public static Butacas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Butacas();
            }
            return instancia;
        }

        //Constructores
        public Butacas()
        {
            Fila = "";
            numero = 0;
            estado = "";
        }

        public Butacas(string fila, int numero, string estado)
        {
            this.Fila = fila;
            this.Numero = numero;
            this.Estado = estado;
        }


        //Propiedades
        public string Fila { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }


        //Metodos
        //public string Validar_estado(string validar)
        //{
        //    List<string> estados_disponibles = new List<string>();
        //    //Cargar lista "estados disponibles" de la tabla estados
        //    foreach (string est in estados_disponibles)
        //    {
        //        if (validar == est)
        //        {
        //            return validar;
        //        }
        //    }
        //    return "Disponible"; //Ver como regresar el valor bien
        //}

        public void Cambiar_estado(string nuevo_estado)
        {
            Estado = nuevo_estado;
        }

    }
}
