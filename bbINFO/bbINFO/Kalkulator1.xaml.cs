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
    public partial class Kalkulator1 : ContentPage
    {
        putnickoVozilo putnickoVozilo;
        motocikli motocikl;
        public Kalkulator1()
        {
            InitializeComponent();
            
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            putnickoVozilo = new putnickoVozilo();
            await Navigation.PushAsync(new Kalkulator2(putnickoVozilo));

        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            motocikl = new motocikli();
            await Navigation.PushAsync(new KalkulatorMotocikli(motocikl));


        }
    }

    public class motocikli
    {
        private int _godinaProizvodnje;
        private int _zapremina;
        private int _kategorija;
        private int _vrstaMotora;
        private int _premija;
        private int _vrstaRegistracije;

        public motocikli()
        {
            this._godinaProizvodnje = 0;
            this._zapremina = 0;
            this._kategorija = 100;
            this._vrstaMotora = 100;
            this._premija = 100;
            this._vrstaRegistracije = 100;

        }

        public int GodinaProizvodnje
        {
            get { return _godinaProizvodnje; }
            set { _godinaProizvodnje = value; }
        }

        public int Zapremina
        {
            get { return _zapremina; }
            set { _zapremina = value; }
        }

        public int Kategorija
        {
            get { return _kategorija; }
            set { _kategorija = value; }
        }

        public int VrstaMotora
        {
            get { return _vrstaMotora; }
            set { _vrstaMotora = value; }
        }

        public int Premija
        {
            get { return _premija; }
            set { _premija = value; }
        }

        public int VrstaRegistracije
        {
            get { return _vrstaRegistracije; }
            set { _vrstaRegistracije = value; }
        }

    }

    public class putnickoVozilo
    {
        private int _godinaProizvodnje;
        private int _zapremina;
        private int _snaga;
        private int _vrstaGoriva;
        private int _premija;
        private int _vrstaRegistracije;

        public putnickoVozilo()
        {
            this._godinaProizvodnje = 0;
            this._zapremina = 0;
            this._snaga = 100;
            this._vrstaGoriva = 100;
            this._premija = 100;
            this._vrstaRegistracije = 100;
        }


        public int GodinaProizvodnje
        {
            get { return _godinaProizvodnje; }
            set { _godinaProizvodnje = value; }
        }

        public int Zapremina
        {
            get { return _zapremina; }
            set { this._zapremina = value; }
        }

        public int Snaga
        {
            get { return _snaga; }
            set { this._snaga = value; }
        }

        public int VrstaGoriva
        {
            get { return _vrstaGoriva; }
            set { this._vrstaGoriva = value; }
        }

        public int Premija
        {
            get { return _premija; }
            set { this._premija = value; }
        }

        public int VrstaRegistracije
        {
            get { return _vrstaRegistracije; }
            set { this._vrstaRegistracije = value; }
        }




    }
}