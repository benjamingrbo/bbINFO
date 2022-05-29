using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace bbINFO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tehnicki3 : ContentPage
    {
        StanicaTehnickogPregleda stanicaTehnickog;
        public Tehnicki3(StanicaTehnickogPregleda proslijedjenaStanica)
        {
            InitializeComponent();
            stanicaTehnickog = proslijedjenaStanica;

            slika.Source = proslijedjenaStanica.Slika;
            naziv.Text = proslijedjenaStanica.Naziv;
            adresa.Text += proslijedjenaStanica.Adresa;
            brojTelefona.Text += proslijedjenaStanica.BrojTelefona;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PhoneDialer.Open(stanicaTehnickog.BrojTelefona);


        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {

            await Map.OpenAsync(stanicaTehnickog.Longituda, stanicaTehnickog.Latituda);
        }
    }
}