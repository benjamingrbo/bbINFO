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
    public partial class Osiguranja1 : ContentPage
    {
        public Osiguranja1()
        {
            InitializeComponent();

            List<OsiguravajuceKuce> listaKucaSarajevo = new List<OsiguravajuceKuce>();
            List<OsiguravajuceKuce> listaKucaMostar = new List<OsiguravajuceKuce>();

            List<Grad> listaGradova = new List<Grad>();

            listaKucaSarajevo.Add(new OsiguravajuceKuce(1, "Sarajevo Osiguranje","Maršala Tita 29", "033569600", "sarajevoOsiguranje.png", 43.859008911817924, 18.421064153344062));
            listaKucaSarajevo.Add(new OsiguravajuceKuce(2, "GRAWE Osiguranje","Put života 12", "033222222", "graweOsiguranje.jpg", 43.85877735564637, 18.396002627090844));

            listaKucaMostar.Add(new OsiguravajuceKuce(1, "Wiener Osiguranje", "Kralja Zvonimira 13", "036335150", 43.344831060239294, 17.80430346137045));
            listaKucaMostar.Add(new OsiguravajuceKuce(2, "Adriatic Osiguranje", "Vukovarska 1", "033444444", 43.35097724849076, 17.7975565));

            listaGradova.Add(new Grad(1, "Sarajevo", listaKucaSarajevo));
            listaGradova.Add(new Grad(2, "Mostar", listaKucaMostar));



            GradoviView.ItemsSource = listaGradova;

        }

        private async void GradoviView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Grad oznaceniGrad = (Grad) e.SelectedItem;

            await Navigation.PushAsync(new Osiguranja2(oznaceniGrad));

        }
    }

    public class OsiguravajuceKuce
    {
        private int _id;
        private string _naziv;
        private string _brojTelefona;
        private string _adresa;
        private string _slika;
        private double _longituda;
        private double _latituda;


        public OsiguravajuceKuce(int uneseniId, string uneseniNaziv, string unesenaAdresa, string uneseniBrojTelefona, double unesenaLongituda, double unesenaLatituda)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
            this._adresa = unesenaAdresa;
            this._brojTelefona = uneseniBrojTelefona;
            this._longituda = unesenaLongituda;
            this._latituda = unesenaLatituda;
        }

        public OsiguravajuceKuce(int uneseniId, string uneseniNaziv, string unesenaAdresa, string uneseniBrojTelefona, string unesenaSlika, double unesenaLongituda, double unesenaLatituda)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
            this._adresa = unesenaAdresa;
            this._brojTelefona = uneseniBrojTelefona;
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

        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }

        }

        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { _brojTelefona = value; }
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


        public override string ToString()
        {
            return this._id + " " + this._naziv + " " + this._brojTelefona;
        }

    }


    public class Grad
    {
        private int _id;
        private string _naziv;
        private List<OsiguravajuceKuce> _listaOsiguravajucihKuca;

        public Grad(int uneseniId, string uneseniNaziv, List<OsiguravajuceKuce> unesenaLista)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
            _listaOsiguravajucihKuca = unesenaLista;
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

        public List<OsiguravajuceKuce> ListaOsiguravajucihKuca
        {
            get { return _listaOsiguravajucihKuca; }
            set
            {
                _listaOsiguravajucihKuca = value;
            }

        }

        public override string ToString()
        {
            return this._id + " " + this._naziv + " " + this._listaOsiguravajucihKuca;
        }
    }
}