using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bbINFO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tehnicki1 : ContentPage
    {
        public Tehnicki1()
        {
            InitializeComponent();

            List<Grad> listaGradova = App.listaGradova as List<Grad>;
            Grad Sarajevo = App.Sarajevo as Grad;
            Grad Mostar = App.Mostar as Grad;
            Grad Zenica = App.Zenica as Grad;
            Grad Tuzla = App.Tuzla as Grad;

            List<StanicaTehnickogPregleda> listaStanicaSarajevo = new List<StanicaTehnickogPregleda>();
            List<StanicaTehnickogPregleda> listaStanicaMostar = new List<StanicaTehnickogPregleda>();
            List<StanicaTehnickogPregleda> listaStanicaZenica = new List<StanicaTehnickogPregleda>();
            List<StanicaTehnickogPregleda> listaStanicaTuzla = new List<StanicaTehnickogPregleda>();


            listaStanicaSarajevo.Add(new StanicaTehnickogPregleda(1, "Remis", "Dzemala Bijedica St 139", "033466537", "remis.png", 43.84937706634823, 18.354526371637856));
            listaStanicaSarajevo.Add(new StanicaTehnickogPregleda(2, "Agram", "Bulevar Meše Selimovića 20", "033755403", "agram.png", 43.84598133788977, 18.342788992155352));
            listaStanicaSarajevo.Add(new StanicaTehnickogPregleda(3, "Autocentar BH", "Džemala Bijedića 165B", "033719241", "autocentar.png", 43.84858502788021, 18.35023193385263));

            listaStanicaMostar.Add(new StanicaTehnickogPregleda(1, "ASA Assistance", "Bišće Polje bb", "036576092", "asa.png", 43.31781572254408, 17.828699956552818));
            listaStanicaMostar.Add(new StanicaTehnickogPregleda(2, "Testing centar", "Bišće Polje bb", "036445703", "testingCentar.jpg", 43.309886620330886, 17.821849137783282));
            listaStanicaMostar.Add(new StanicaTehnickogPregleda(3, "ASA Assistance", "Sutina bb", "036558072", "asa.png", 43.36385644112063, 17.818535358130323));

            listaStanicaZenica.Add(new StanicaTehnickogPregleda(1, "Autocentar BH", "Zmaja od Bosne 27", "032440180", "autocentar.png", 44.211246192584, 17.907819295369954));
            listaStanicaZenica.Add(new StanicaTehnickogPregleda(2, "REMIS Zenica", "Vatrogasni put", "032407279", "remis.png", 44.20722353355111, 17.903962673216963));
            listaStanicaZenica.Add(new StanicaTehnickogPregleda(3, "BiHAMK", "Blatuša bb", "032245676", "bihamk.png", 44.21342240752859, 17.912784412352625));

            listaStanicaTuzla.Add(new StanicaTehnickogPregleda(1, "STP Agram", "Mije Keroševića Guje bb", "035210803", "agram.png", 44.53486284330411, 18.651825687421184));
            listaStanicaTuzla.Add(new StanicaTehnickogPregleda(2, "SAMN d.o.o.", "Nikole Tesle bb", "035290365", "SAMN.png", 44.52763746750876, 18.627853790883552));
            listaStanicaTuzla.Add(new StanicaTehnickogPregleda(3, "Polo", "Krojčica", "035312490", "polo.png", 44.53021771986504, 18.651305831578348));





            Sarajevo.ListaStanicaTehnickogPregleda = listaStanicaSarajevo;
            Mostar.ListaStanicaTehnickogPregleda = listaStanicaMostar;
            Zenica.ListaStanicaTehnickogPregleda = listaStanicaZenica;
            Tuzla.ListaStanicaTehnickogPregleda = listaStanicaTuzla;

            GradoviView.ItemsSource = listaGradova;





        }

        private async void GradoviView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Grad oznaceniGrad = (Grad)e.SelectedItem;

            await Navigation.PushAsync(new Tehnicki2(oznaceniGrad));

        }
    }

    public class StanicaTehnickogPregleda
    {
        private int _id;
        private string _naziv;
        private string _brojTelefona;
        private string _adresa;
        private string _slika;
        private double _longituda;
        private double _latituda;

        public StanicaTehnickogPregleda(int uneseniId, string uneseniNaziv, string unesenaAdresa, string uneseniBroj, string unesenaSlika, double unesenaLongituda, double unesenaLatituda)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
            this._brojTelefona = uneseniBroj;
            this._adresa = unesenaAdresa;
            this._slika = unesenaSlika;
            this._longituda = unesenaLongituda;
            this._latituda = unesenaLatituda;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { _brojTelefona = value; }
        }

        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }

        public string Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }

        public double Longituda
        {
            get { return _longituda; }
            set { _longituda = value; }
        }

        public double Latituda
        {
            get { return _latituda; }
            set { _latituda = value; }
        }
    }
}