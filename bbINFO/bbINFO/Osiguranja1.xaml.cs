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

            List<Grad> listaGradova = App.listaGradova as List<Grad>;
            Grad Sarajevo = App.Sarajevo as Grad;
            Grad Mostar = App.Mostar as Grad;
            Grad Zenica = App.Zenica as Grad;
            Grad Tuzla = App.Tuzla as Grad;


            List<OsiguravajuceKuce> listaKucaSarajevo = new List<OsiguravajuceKuce>();
            List<OsiguravajuceKuce> listaKucaMostar = new List<OsiguravajuceKuce>();
            List<OsiguravajuceKuce> listaKucaZenica = new List<OsiguravajuceKuce>();
            List<OsiguravajuceKuce> listaKucaTuzla = new List<OsiguravajuceKuce>();



            listaKucaSarajevo.Add(new OsiguravajuceKuce(1, "Sarajevo Osiguranje", "Maršala Tita 29", "033569600", "sarajevoOsiguranje.png", 43.859008911817924, 18.421064153344062));
            listaKucaSarajevo.Add(new OsiguravajuceKuce(2, "GRAWE Osiguranje", "Put života 12", "033222222", "graweOsiguranje.jpg", 43.85877735564637, 18.396002627090844));
            listaKucaSarajevo.Add(new OsiguravajuceKuce(3, "UNIQA Osiguranje", "Obala Kulina bana 19", "033289000", "uniqa.png", 43.85512707965864, 18.39957351314499));
            
            listaKucaMostar.Add(new OsiguravajuceKuce(1, "Wiener Osiguranje", "Kralja Zvonimira 13", "036335150","wiener.jpg", 43.344831060239294, 17.80430346137045));
            listaKucaMostar.Add(new OsiguravajuceKuce(2, "Adriatic Osiguranje", "Vukovarska 1", "036311710","adriatic.png", 43.35097724849076, 17.7975565));
            listaKucaMostar.Add(new OsiguravajuceKuce(3, "TRIGLAV Osiguranje", "Dr. Ante Starčevića", "036334700", "triglav.png", 43.34627879883737, 17.80701235686997));


            listaKucaZenica.Add(new OsiguravajuceKuce(1, "Wiener Osiguranje", "Trg Alije Izetbegovića 73", "032209570", "wiener.jpg", 44.1988146676847, 17.91237013104407));
            listaKucaZenica.Add(new OsiguravajuceKuce(2, "Premium Osiguranje", "Bulevar Kulina bana 28a", "061401305", "premium.jpeg", 44.20385678185406, 17.907543383589047));
            listaKucaZenica.Add(new OsiguravajuceKuce(3, "Dunav Osiguranje", "Uzunovića put 6", "063835082","dunav.png", 44.194563153791144, 17.909510220997106));


            listaKucaTuzla.Add(new OsiguravajuceKuce(1, "GRAWE Osiguranje", "Klosterska 22", "035249200", "graweOsiguranje.jpg", 44.53698043088078, 18.6802506828676));
            listaKucaTuzla.Add(new OsiguravajuceKuce(2, "Euroherc Osiguranje", "Mije Keroševića Guje bb", "035320400", "euroHerc.jpg", 44.53498917547406, 18.652201634373814));
            listaKucaTuzla.Add(new OsiguravajuceKuce(3, "Camelija osiguranje", "Mehmedalije Maka Dizdara bb", "035246090", "kamelija.jpg", 44.531073675730624, 18.69081971033137));




            Sarajevo.ListaOsiguravajucihKuca = listaKucaSarajevo;
            Mostar.ListaOsiguravajucihKuca = listaKucaMostar;
            Zenica.ListaOsiguravajucihKuca = listaKucaZenica;
            Tuzla.ListaOsiguravajucihKuca = listaKucaTuzla;

            



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
        private List<StanicaTehnickogPregleda> _listaStanicaTehnickogPregleda;
        
        public Grad()
        {

        }

        public Grad(int uneseniId, string uneseniNaziv)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
            
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

        public List<StanicaTehnickogPregleda> ListaStanicaTehnickogPregleda
        {
            get { return _listaStanicaTehnickogPregleda; }
            set { _listaStanicaTehnickogPregleda = value; }
        }

        public override string ToString()
        {
            return this._id + " " + this._naziv + " " + this._listaOsiguravajucihKuca;
        }
    }
}