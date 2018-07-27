using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p2.Models
{
    public class Director:Persona   
    {
        private TipoCine tipopeliculas;

        public Director(string pNombre, string pApellido, int pAño, TipoCine pTipo) : base(pNombre, pApellido, pAño)
        {
            this.tipopeliculas = pTipo;
        }

        public TipoCine TipoPeliculas
        {
            get { return tipopeliculas; }
            set { tipopeliculas = value; }
        }

    }


    public enum TipoCine { Acción, Drama, Humor, CienciaFicción, Animación };
}