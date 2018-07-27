using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p2.Models
{
    public class Actor:Persona
    {
        private bool hasidoprincipal;

        public Actor(string pNombre, string pApellido, int pAño, bool pPrincipal) : base(pNombre, pApellido, pAño)
        {
            this.hasidoprincipal = pPrincipal;
        }

        public bool HaSidoPrincipal
        {
            get { return hasidoprincipal; }
            set { hasidoprincipal = value; }
        }

    }
}