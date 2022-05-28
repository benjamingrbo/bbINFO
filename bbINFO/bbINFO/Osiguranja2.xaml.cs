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
    public partial class Osiguranja2 : ContentPage
    {
        public Osiguranja2(Grad proslijedjeniGrad)
        {
            InitializeComponent();


            osiguravajuceKuceView.ItemsSource = proslijedjeniGrad.ListaOsiguravajucihKuca;
        }

        private async void osiguravajuceKuceView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            OsiguravajuceKuce oznacenoOsiguranje = (OsiguravajuceKuce) e.SelectedItem;

            await Navigation.PushAsync(new Osiguranja3(oznacenoOsiguranje));

        }
    }
}