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
        public static List<snagaMotora> snagaMotora;
        public Kalkulator2(putnickoVozilo vozilo)
        {
            InitializeComponent();
            vrsteGoriva = new List<Gorivo>();
            snagaMotora = new List<snagaMotora>();


            Gorivo benzin = new Gorivo(1, "Benzin");
            Gorivo dizel = new Gorivo(2, "Dizel");
            Gorivo plin = new Gorivo(3, "Plin");


            snagaMotora.Add(new snagaMotora(1, "Manje od 22 kW"));
            snagaMotora.Add(new snagaMotora(2, "22kW - 33kW"));
            snagaMotora.Add(new snagaMotora(3, "34kW - 44kW"));
            snagaMotora.Add(new snagaMotora(4, "45kW - 55kW"));
            snagaMotora.Add(new snagaMotora(5, "56kW - 66kW"));
            snagaMotora.Add(new snagaMotora(6, "67kW - 70kW"));
            snagaMotora.Add(new snagaMotora(7, "71kW - 84kW"));
            snagaMotora.Add(new snagaMotora(8, "85kW - 100kW"));
            snagaMotora.Add(new snagaMotora(9, "101kW - 110kW"));
            snagaMotora.Add(new snagaMotora(10, "111kW - 130kW"));
            snagaMotora.Add(new snagaMotora(11, "Više od 130kW"));

            vrsteGoriva.Add(benzin);
            vrsteGoriva.Add(dizel);
            vrsteGoriva.Add(plin);


            pickerSnage.ItemsSource = snagaMotora;
            pickerGoriva.ItemsSource = vrsteGoriva;


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
}