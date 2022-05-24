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
    public partial class Kalkulator3 : ContentPage
    {
        public Kalkulator3(putnickoVozilo voziloZaRegistraciju, dodatneOpcije dodatneOpcijeZaRegistraciju)
        {
            InitializeComponent();
            

        }
    }

    public class registracija
    {
        private double polisa;
        private double tehnickiPregled;
        private double pomocNaCestiBihamk;
        private double putarina;
       
    }
}