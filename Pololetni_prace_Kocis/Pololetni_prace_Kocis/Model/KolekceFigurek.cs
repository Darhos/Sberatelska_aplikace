using System;
using System.Collections.Generic;
using System.Text;
using Pololetni_prace_Kocis.Model;

namespace Pololetni_prace_Kocis.Model
{
    class KolekceFigurek
    {
        public static KolekceFigurek kolekceFigurek = new KolekceFigurek();

        protected List<Figurka> kolekce;

        public KolekceFigurek()
        {
            kolekce = new List<Figurka>();
        }
        public List<Figurka> Kolekce { get { return kolekce; } set { kolekce = value; } }

    }
}
