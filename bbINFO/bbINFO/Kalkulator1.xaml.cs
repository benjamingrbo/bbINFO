﻿using System;
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
        public Kalkulator1()
        {
            InitializeComponent();
            
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            putnickoVozilo = new putnickoVozilo();
            await Navigation.PushAsync(new Kalkulator2(putnickoVozilo));

        }
    }

    public class putnickoVozilo
    {
        private int _godinaProizvodnje;
        private int _zapremina;
        private int _snaga;
        private int _vrstaGoriva;

        public putnickoVozilo()
        {
            this._godinaProizvodnje = 0;
            this._zapremina = 0;
            this._snaga = 0;
            this._vrstaGoriva = 0;
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
            set { this.VrstaGoriva = value; }
        }


    }
}