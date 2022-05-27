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
    public partial class KalkulatorMotocikli : ContentPage
    {
        public motocikli motocikl1;
        public dodatneOpcijeZaMotocikl dodatneOpcijeZaRegMotocikla;
        public KalkulatorMotocikli(motocikli motocikl)
        {
            InitializeComponent();
            motocikl1 = motocikl;
            dodatneOpcijeZaRegMotocikla = new dodatneOpcijeZaMotocikl();

            List<string> listaKategorija = new List<string>();
            List<string> listaVrstaMotora = new List<string>();
            List<string> listaPremijskiRazred = new List<string>();
            List<string> listaVrstaRegistrovanja = new List<string>();
            List<string> listaZapremina = new List<string>();

            listaKategorija.Add("L1");
            listaKategorija.Add("L2");
            listaKategorija.Add("L3");
            listaKategorija.Add("L4");
            listaKategorija.Add("L5");
            listaKategorija.Add("L6");
            listaKategorija.Add("L7");

            listaVrstaMotora.Add("Dvotaktni");
            listaVrstaMotora.Add("Četverotaktni");

            listaPremijskiRazred.Add("0%");
            listaPremijskiRazred.Add("10%");
            listaPremijskiRazred.Add("20%");
            listaPremijskiRazred.Add("30%");
            listaPremijskiRazred.Add("40%");
            listaPremijskiRazred.Add("50%");


            listaVrstaRegistrovanja.Add("Prva registracija");
            listaVrstaRegistrovanja.Add("Produženje registracije");
            listaVrstaRegistrovanja.Add("Promjena vlasništva");

            listaZapremina.Add("< 50 ccm");
            listaZapremina.Add("50 ccm - 100 ccm");
            listaZapremina.Add("100 ccm - 175 ccm");
            listaZapremina.Add("175 ccm - 250 ccm");
            listaZapremina.Add("250 ccm - 500 ccm");
            listaZapremina.Add("500 ccm - 750 ccm");
            listaZapremina.Add("preko 750 ccm");





            pickerKategorije.ItemsSource = listaKategorija;
            pickerVrsteMotora.ItemsSource = listaVrstaMotora;
            pickerPremijeMotocikla.ItemsSource = listaPremijskiRazred;
            pickerVrsteRegistrovanjaMotocikla.ItemsSource = listaVrstaRegistrovanja;
            pickerZapremine.ItemsSource = listaZapremina;


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            motocikl1.Zapremina = pickerZapremine.SelectedIndex;
            motocikl1.GodinaProizvodnje = int.Parse(godinaProizvodnjeMotocikla.Text);
            motocikl1.Kategorija = pickerKategorije.SelectedIndex;
            motocikl1.VrstaMotora = pickerVrsteMotora.SelectedIndex;
            motocikl1.Premija = pickerPremijeMotocikla.SelectedIndex;
            motocikl1.VrstaRegistracije = pickerVrsteRegistrovanjaMotocikla.SelectedIndex;

            dodatneOpcijeZaRegMotocikla.zeleniKarton = switchZeleniKartonZaMotocikl.IsToggled;
            dodatneOpcijeZaRegMotocikla.registarskeTablice = switchNoveRegistarskeTabliceZaMotocikl.IsToggled;
            dodatneOpcijeZaRegMotocikla.potvrdaOVlasnistvu = switchPotvrdaOVlasnistvuZaMotocikl.IsToggled;
            dodatneOpcijeZaRegMotocikla.potvrdaORegistraciji = switchPotvrdaORegistracijiZaMotocikl.IsToggled;
            dodatneOpcijeZaRegMotocikla.izgubljeneTablice = switchIzgubljeneTabliceZaMotocikl.IsToggled;

            await Navigation.PushAsync(new KalkulatorMotocikli2(motocikl1, dodatneOpcijeZaRegMotocikla));




        }
    }


    public class dodatneOpcijeZaMotocikl
    {
        private bool _zeleniKarton;
        private bool _registarskeTablice;
        private bool _potvrdaOVlasnistvu;
        private bool _potvrdaORegistraciji;
        private bool _izgubljeneTablice;




        public dodatneOpcijeZaMotocikl()
        {
            this._zeleniKarton = false;
            this._registarskeTablice = false;
            this._potvrdaOVlasnistvu = false;
            this._potvrdaORegistraciji = false;
            this._izgubljeneTablice = false;

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


        public bool potvrdaORegistraciji
        {
            get { return this._potvrdaORegistraciji; }
            set { this._potvrdaORegistraciji = value; }
        }


        public bool izgubljeneTablice
        {
            get { return this._izgubljeneTablice; }
            set { this._izgubljeneTablice = value; }
        }


    }
}