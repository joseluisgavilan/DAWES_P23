using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p2.Models
{
    public class Película
    {
        private string titulo;

        public string Titulo        
        {
            get { return titulo; }
            set { titulo = value; }
        }


        private Persona direccion;

        public Persona Dirección
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int año;

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public static Película GetTuPelículaFavorita()
        {
            Película p = new Película
            {
                Titulo = "2046",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2004
            };

            return p;

        }


        public static List<Película> GetListaPelículas()
        {
            List<Película> ListaPelis =new List<Película>();

            Película p = new Película
            {
                Titulo = "2046",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2004
            };

            ListaPelis.Add(p);

             p = new Película
            {
                Titulo = "In the mood of love",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2000
            };
            ListaPelis.Add(p);

            p = new Película
            {
                Titulo = "My blueberry nights",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2007
            };
            ListaPelis.Add(p);


            return ListaPelis;

        }

    }
}