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
    public partial class Tehnicki2 : ContentPage
    {
        public Tehnicki2(Grad proslijedjeniGrad)
        {
            InitializeComponent();

            staniceTehnickogPregledaView.ItemsSource = proslijedjeniGrad.ListaStanicaTehnickogPregleda;
        }

        private async void staniceTehnickogPregledaView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            StanicaTehnickogPregleda oznacenaStanicaTehnickogPregleda = (StanicaTehnickogPregleda)e.SelectedItem;

            await Navigation.PushAsync(new Tehnicki3(oznacenaStanicaTehnickogPregleda));

        }
    }
}