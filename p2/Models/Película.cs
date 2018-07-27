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


        public static Película[] GetListaPelículas()
        {
            Película[] ArrayPelis=new Película[3];

            Película p = new Película
            {
                Titulo = "2046",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2004
            };

            ArrayPelis[0] = p;

             p = new Película
            {
                Titulo = "In the mood of love",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2000
            };
            ArrayPelis[1] = p;

            p = new Película
            {
                Titulo = "My blueberry nights",
                Dirección = new Persona("Wong ", "Kar Wai", 1958),
                Año = 2007
            };
            ArrayPelis[2] = p;

            
            return ArrayPelis;

        }

    }
}