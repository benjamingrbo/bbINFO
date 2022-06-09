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
    public partial class Kalkulator2 : ContentPage
    {
        public static List<Gorivo> vrsteGoriva;
        public static List<snagaMotora> snagaMotoraLista;
        public static List<premija> premijskiRazred;
        public putnickoVozilo putnickoVoziloZaRegistraciju;
        public dodatneOpcije dodatneOpcije1;
        public static List<vrstaRegistrovanja> vrstaRegistrovanjaLista;


        public Kalkulator2(putnickoVozilo vozilo)
        {
            putnickoVoziloZaRegistraciju = vozilo;

            InitializeComponent();
            vrsteGoriva = new List<Gorivo>();
            snagaMotoraLista = new List<snagaMotora>();
            premijskiRazred = new List<premija>();
            dodatneOpcije1 = new dodatneOpcije();
            vrstaRegistrovanjaLista = new List<vrstaRegistrovanja>();






            vrsteGoriva.Add(new Gorivo(1, "Benzin"));
            vrsteGoriva.Add(new Gorivo(2, "Dizel"));
            vrsteGoriva.Add(new Gorivo(3, "Plin"));




            snagaMotoraLista.Add(new snagaMotora(1, "Do 22kW"));
            snagaMotoraLista.Add(new snagaMotora(2, "22kW - 33kW"));
            snagaMotoraLista.Add(new snagaMotora(3, "34kW - 44kW"));
            snagaMotoraLista.Add(new snagaMotora(4, "45kW - 55kW"));
            snagaMotoraLista.Add(new snagaMotora(5, "56kW - 66kW"));
            snagaMotoraLista.Add(new snagaMotora(6, "67kW - 84kW"));
            snagaMotoraLista.Add(new snagaMotora(7, "85kW - 110kW"));
            snagaMotoraLista.Add(new snagaMotora(8, "Preko 110kW"));

            premijskiRazred.Add(new premija(0, 0.0, "0%"));
            premijskiRazred.Add(new premija(1, 0.1, "10%"));
            premijskiRazred.Add(new premija(2, 0.2, "20%"));
            premijskiRazred.Add(new premija(3, 0.3, "30%"));
            premijskiRazred.Add(new premija(4, 0.4, "40%"));
            premijskiRazred.Add(new premija(5, 0.5, "50%"));


            vrstaRegistrovanjaLista.Add(new vrstaRegistrovanja(0, "Prva registracija"));
            vrstaRegistrovanjaLista.Add(new vrstaRegistrovanja(1, "Produženje registracije"));
            vrstaRegistrovanjaLista.Add(new vrstaRegistrovanja(2, "Promjena vlasništva"));






            pickerSnage.ItemsSource = snagaMotoraLista;
            pickerGoriva.ItemsSource = vrsteGoriva;
            pickerPremije.ItemsSource = premijskiRazred;
            pickerVrsteRegistrovanja.ItemsSource = vrstaRegistrovanjaLista;



        }

        async private void Button_Clicked(object sender, EventArgs e)

        {
            try
            {

                putnickoVoziloZaRegistraciju.GodinaProizvodnje = int.Parse(godinaProizvodnjeEntry.Text);
                putnickoVoziloZaRegistraciju.Zapremina = int.Parse(zapreminaMotoraEntry.Text);
                putnickoVoziloZaRegistraciju.Snaga = pickerSnage.SelectedIndex;
                putnickoVoziloZaRegistraciju.VrstaGoriva = pickerGoriva.SelectedIndex;
                putnickoVoziloZaRegistraciju.Premija = pickerPremije.SelectedIndex;
                putnickoVoziloZaRegistraciju.VrstaRegistracije = pickerVrsteRegistrovanja.SelectedIndex;



                dodatneOpcije1.zeleniKarton = switchZeleniKarton.IsToggled;
                dodatneOpcije1.registarskeTablice = switchNoveRegistarskeTablice.IsToggled;
                dodatneOpcije1.potvrdaORegistraciji = switchPotvrdaORegistraciji.IsToggled;
                dodatneOpcije1.potvrdaOVlasnistvu = switchPotvrdaOVlasnistvu.IsToggled;
                dodatneOpcije1.popustZaInvalide = switchPopustZaInvalide.IsToggled;
                dodatneOpcije1.taxiVozilo = switchTaxiVozilo.IsToggled;
                dodatneOpcije1.BrojPutnika = int.Parse(brojPutnika.Text);
                dodatneOpcije1.izgubljeneTablice = switchIzgubljeneTablice.IsToggled;
                dodatneOpcije1.Terenac = switchTerenac.IsToggled;





                await Navigation.PushAsync(new Kalkulator3(putnickoVoziloZaRegistraciju, dodatneOpcije1));
            }
            catch
            {
                await DisplayAlert("Upozorenje", "Sva polja moraju biti ispunjena!", "OK");
            }






        }

    }

    public class Gorivo
    {
        private int _id;
        private string _naziv;


        public Gorivo(int uneseniId, string uneseniNaziv)
        {
            this._id = uneseniId;
            this._naziv = uneseniNaziv;
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Naziv
        {
            get { return this._naziv; }
            set { this._naziv = value; }
        }

    }


    public class snagaMotora
    {
        private int _id;
        private string _raspon;

        public snagaMotora(int uneseniId, string uneseniRaspon)
        {
            this._id = uneseniId;
            this._raspon = uneseniRaspon;

        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Raspon
        {
            get { return this._raspon; }
            set { this._raspon = value; }
        }
    }

    public class premija
    {
        private int _id;
        private double _postotak;
        private string _postotakZaIspis;

        public premija(int uneseniId, double uneseniPostotak, string uneseniPostotakZaIspis)
        {
            this._id = uneseniId;
            this._postotak = uneseniPostotak;
            this._postotakZaIspis = uneseniPostotakZaIspis;

        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public double Postotak
        {
            get { return this._postotak; }
            set { this._postotak = value; }
        }

        public string PostotakZaIspis
        {
            get { return this._postotakZaIspis; }
            set { this._postotakZaIspis = value; }
        }


    }


    public class dodatneOpcije
    {
        private bool _zeleniKarton;
        private bool _registarskeTablice;
        private bool _potvrdaOVlasnistvu;
        private bool _potvrdaORegistraciji;
        private bool _popustZaInvalide;
        private bool _taxiVozilo;
        private int _brojPutnika;
        private bool _izgubljeneTablice;
        private bool _terenac;



        public dodatneOpcije()
        {
            this._zeleniKarton = false;
            this._registarskeTablice = false;
            this._potvrdaOVlasnistvu = false;
            this._brojPutnika = 0;
            this._potvrdaORegistraciji = false;
            this._taxiVozilo = false;
            this._izgubljeneTablice = false;
            this._popustZaInvalide = false;

        }

        public bool zeleniKarton
        {
            get { return this._zeleniKarton; }
            set { this._zeleniKarton = value; }
        }

        public bool registarskeTablice
        {
            get { return this._registarskeTablice; }
            set { this._registarskeTablice = value; }
        }

        public bool potvrdaOVlasnistvu
        {
            get { return this._potvrdaOVlasnistvu; }
            set { this._potvrdaOVlasnistvu = value; }
        }

        public int BrojPutnika
        {
            get { return this._brojPutnika; }
            set { this._brojPutnika = value; }
        }

        public bool potvrdaORegistraciji
        {
            get { return this._potvrdaORegistraciji; }
            set { this._potvrdaORegistraciji = value; }
        }

        public bool taxiVozilo
        {
            get { return this._taxiVozilo; }
            set { this._taxiVozilo = value; }
        }

        public bool izgubljeneTablice
        {
            get { return this._izgubljeneTablice; }
            set { this._izgubljeneTablice = value; }
        }

        public bool popustZaInvalide
        {
            get { return this._popustZaInvalide; }
            set { this._popustZaInvalide = value; }
        }

        public bool Terenac
        {
            get { return this._terenac; }
            set { this._terenac = value; }
        }



    }


    public class vrstaRegistrovanja
    {
        private int _id;
        private string _vrsta;

        public vrstaRegistrovanja(int uneseniId, string unesenaVrsta)
        {
            _id = uneseniId;
            _vrsta = unesenaVrsta;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }


        public string Vrsta
        {
            get { return _vrsta; }
            set { _vrsta = value; }
        }
    }
}