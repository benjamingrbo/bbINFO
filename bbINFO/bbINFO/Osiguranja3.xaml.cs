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
    public partial class Osiguranja3 : ContentPage
    {

        public OsiguravajuceKuce osiguranje;
        public Osiguranja3(OsiguravajuceKuce oznacenoOsiguranje)
        {
            InitializeComponent();
            osiguranje = oznacenoOsiguranje;

            slika.Source = oznacenoOsiguranje.Slika;
            naziv.Text = oznacenoOsiguranje.Naziv;
            adresa.Text += oznacenoOsiguranje.Adresa;
            brojTelefona.Text += oznacenoOsiguranje.BrojTelefona;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PhoneDialer.Open(osiguranje.BrojTelefona);

        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Map.OpenAsync(osiguranje.Longituda, osiguranje.Latituda);

        }
    }
}