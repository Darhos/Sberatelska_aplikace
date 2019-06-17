using System;
using System.Collections.Generic;
using System.Text;

namespace Pololetni_prace_Kocis.Model
{
    class Figurka : Pololetni_prace_Kocis.ViewModel.Abstract.ViewModel
    {
        //Model pro informace o jednotlivých figurkách (název, druh, číslo)
        public string nazev;

        public string Nazev
        {
            get { return this.nazev; }
            set { nazev = value; this.OnPropertyChanged(); }
        }

        public string druh;

        public string Druh
        {
            get { return this.druh; }
            set { druh = value; this.OnPropertyChanged(); }
        }

        public string cislo;

        public string Cislo
        {
            get { return this.cislo; }
            set { cislo = value; this.OnPropertyChanged(); }
        }
    }
}
