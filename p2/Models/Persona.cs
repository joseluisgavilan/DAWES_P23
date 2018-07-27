using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p2.Models
{
    public class Persona
    {
        public Persona(string pNombre, string pApellido,int pAño )
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.AñoNacimiento = pAño;
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int  añoNacimento;

        public int AñoNacimiento
        {
            get { return añoNacimento; }
            set { añoNacimento = value; }
        }

        public static Persona GetFavorita(bool pEsDirector)
        {
            Persona p;
            if (pEsDirector)
            {
                p = new Director("Jose Luis", "Cuerda", 1956, TipoCine.Humor);
                
            }
            else
            {
                p= new Actor("Fernando", "Rey", 1907, true);
            }
            

            return p;

        }


        public static Persona[] GetListaPersonas()
        {
            Persona[] ArrayPersona = new Persona[3];
            Persona p;

            p = new Director("Jose Luis", "Cuerda", 1956, TipoCine.Humor);
            ArrayPersona[0] = p;
            p = new Actor("Fernando", "Rey", 1907, true);
            ArrayPersona[1] = p;
            p = new Actor("Leticia", "Dolera", 1981, true);
            ArrayPersona[2] = p;

            return ArrayPersona;

        }

    }
}