using System.Collections.Generic;
using Xamarin.Forms;
using Pololetni_prace_Kocis.Model;
using Pololetni_prace_Kocis.View;

namespace Pololetni_prace_Kocis.ViewModel
{
    class MainViewModel : Abstract.ViewModel
    {
        //Konstruktor
        public MainViewModel()
        {
            Pridat = new Command(pridat);
            Zobrazit = new Command(zobrazit);
        }

        //Commandy a proměnné
        public Command Pridat { get; private set; }
        public Command Zobrazit { get; private set; }
        private string FigurkaNazev = "";
        private string FigurkaDruh = "";
        private string FigurkaCislo = "";

        //Vytažení jednotlivých informací z modelu
        public List<Figurka> Kolekcefigurek { get { return KolekceFigurek.kolekceFigurek.Kolekce;} set { KolekceFigurek.kolekceFigurek.Kolekce = value; } }

        public string VstupNazev
        {
            get { return FigurkaNazev; }
            set { FigurkaNazev = value; }
        }

        public string VstupDruh
        {
            get { return FigurkaDruh; }
            set { FigurkaDruh = value; }
        }

        public string VstupCislo
        {
            get { return FigurkaCislo; }
            set { FigurkaCislo = value; }
        }

        //přidání figurky do kolekce
        public void pridat(object sender)
        {
            Figurka fig = new Figurka { nazev = VstupNazev, druh = VstupDruh, cislo = VstupCislo };
            KolekceFigurek.kolekceFigurek.Kolekce.Add(fig);
        } 

        //Zobrazení seznamu
        private void zobrazit()
        {
            App.Current.MainPage = new NavigationPage(new KolekceView());
        }


    }
}
