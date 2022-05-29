using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace bbINFO
{
    public partial class App : Application
    {
        public static List<Grad> listaGradova { get; set; }
        public static Grad Sarajevo { get; set; }
        public static Grad Mostar { get; set; }
        public static Grad Zenica { get; set; }
        public static Grad Tuzla { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPage1();
            listaGradova = new List<Grad>();

            Sarajevo = new Grad(1, "Sarajevo");
            Mostar = new Grad(2, "Mostar");
            Zenica = new Grad(3, "Zenica");
            Tuzla = new Grad(4, "Tuzla");

            listaGradova.Add(Sarajevo);
            listaGradova.Add(Mostar);
            listaGradova.Add(Zenica);
            listaGradova.Add(Tuzla);


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
