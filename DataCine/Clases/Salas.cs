using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Salas
    {
        //Atributos
        private int numero;
        private string tipo;
        private int coste;
        private int asientos_maximos;
        private List<Butacas> lista_butacas;

        private static Salas instancia;

        public static Salas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Salas();
            }
            return instancia;
        }

        //Constructores
        public Salas()
        {
            Numero = 0;
            Tipo = "";
            Coste = 0;
            Asientos_maximos = 0;
            Lista_butacas = new List<Butacas>();
        }

        public Salas(int numero, string tipo, int coste, int asientos_maximos, List<Butacas> lista_butacas)
        {
            this.Numero = numero;
            this.Tipo = tipo;
            this.Coste = coste;
            this.Asientos_maximos = asientos_maximos;
            this.Lista_butacas = lista_butacas;
        }


        //Propiedades
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int Coste { get; set; }
        public int Asientos_maximos { get; set; }
        public List<Butacas> Lista_butacas { get; set; }

    }
}
