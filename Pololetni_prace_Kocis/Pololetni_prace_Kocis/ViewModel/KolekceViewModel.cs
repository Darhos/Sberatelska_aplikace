using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Pololetni_prace_Kocis.Model;
using Pololetni_prace_Kocis.View;
using Pololetni_prace_Kocis.ViewModel;

namespace Pololetni_prace_Kocis.ViewModel
{
    class KolekceViewModel : Abstract.ViewModel
    {
        public KolekceViewModel()
        {
            VsechnyFigurky = new ObservableCollection<Figurka>(kolekceFigurek);
        }

        public List<Figurka> kolekceFigurek { get { return KolekceFigurek.kolekceFigurek.Kolekce; } set { KolekceFigurek.kolekceFigurek.Kolekce = value; } }

        //Vyobrazení figurek
        public ObservableCollection<Figurka> VsechnyFigurky { get; set; }

    }
}
