using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Clases
{
    internal class Peliculas
    {
        //Atributos
        private int id_pelicula;
        private string nombre;
        private string clasificacion;
        private TimeSpan duracion;
        private List<string> generos;
        private List<string> idiomas;

        private static Peliculas instancia;

        public static Peliculas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Peliculas();
            }
            return instancia;
        }
        //Constructores
        Peliculas()
        {
            Id_pelicula = 0;
            Nombre = "";
            Clasificacion = "";
            Duracion = TimeSpan.Zero;
            Generos = new List<string>();
            Idiomas = new List<string>();
        }

        Peliculas(int id_pelicula, string nombre, string clasificacion, TimeSpan duracion, List<string> generos, List<string> idiomas)
        {
            this.Id_pelicula = id_pelicula;
            this.Nombre = nombre;
            this.Clasificacion = clasificacion;
            this.Duracion = duracion;
            this.Generos = generos;
            this.Idiomas = idiomas;
        }


        //Propiedades
        public int Id_pelicula { get; set; }
        public string Nombre { get; set; }
        public string Clasificacion { get; set; }
        public TimeSpan Duracion { get; set; }
        public List<string> Generos { get; set; }
        public List <string> Idiomas { get; set; }


        //Metodos
        // Metodo de prueba
        public string Mostrar_pelicula()
        {
            return Convert.ToString("\nCodigo de pelicula: " + Id_pelicula +
                                "\nNombre: " + Nombre +
                                "\nClasificacion: " + Clasificacion +
                                "\nDuracion: " + Duracion +
                                "\nGeneros: " + Listar(Generos) +
                                "\nIdiomas: " + Listar(Idiomas));
        }

        public string Listar(List<string> lista)
        {
            string cadena = "";
            foreach (string item in lista)
            {
                cadena += ", " + item;
            }
            return cadena;
        }


    }
}
