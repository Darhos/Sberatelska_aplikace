using System.Collections.Generic;
using Xamarin.Forms;
using Pololetni_prace_Kocis.Model;
using Pololetni_prace_Kocis.View;
using System.IO;
using System;

namespace Pololetni_prace_Kocis.ViewModel
{
    class MainViewModel : Abstract.ViewModel
    {
        //Konstruktor
        public MainViewModel()
        {
            Pridat = new Command(pridat);
            Zobrazit = new Command(zobrazit);
            Ulozit = new Command(ulozit);
        }

        //Commandy a proměnné
        public Command Pridat { get; private set; }
        public Command Zobrazit { get; private set; }
        public Command Ulozit { get; private set; }
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

        //Cesta k souboru, do kterého se budou data ukládat
        readonly static string cesta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        readonly string soubor = Path.Combine(cesta, "souborDat.txt");

        //Uložení seznamu
        private void ulozit()
        {
            using (var streamWriter = new StreamWriter(cesta))
            {
                List<Figurka> kolekceFigurek = Kolekcefigurek;
                foreach (Figurka fig in kolekceFigurek)
                {
                    string nazev = fig.nazev;
                    string druh = fig.druh;
                    string cislo = fig.cislo;
                    streamWriter.WriteLine(nazev + ";" + druh + ";" + cislo);
                }
            }
        }
    }
}
