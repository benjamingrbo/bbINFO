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
        public registracija registracijaPutnickogVozila;
        public putnickoVozilo voziloZaRegistraciju;
        public Kalkulator3(putnickoVozilo vozilo, dodatneOpcije dodatneOpcijeZaRegistraciju)
        {
            InitializeComponent();
            registracijaPutnickogVozila = new registracija();
            voziloZaRegistraciju = vozilo;



            izracunajVrijednostPolise();
            porezNaImovinu();
  
             

            polisaIspis.Text = registracijaPutnickogVozila.Polisa.ToString();
            vodoprivredaIspis.Text = registracijaPutnickogVozila.Vodoprivreda.ToString();
            bihamkIspis.Text = registracijaPutnickogVozila.Bihamk.ToString();
            porezIspis.Text = registracijaPutnickogVozila.Porez.ToString();

            

        }


        public void izracunajVrijednostPolise()
        {
            switch (voziloZaRegistraciju.Snaga)
            {
                case 0:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 230;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 207;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 184;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 161;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 138;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 115;
                    }
                    break;

                case 1:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 328;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 295;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 262;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 230;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 197;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 164;
                    }
                    break;

                case 2:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 396;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 356;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 317;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 277;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 238;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 198;
                    }
                    break;

                case 3:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 461;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 415;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 369;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 323;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 277;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 231;
                    }
                    break;

                case 4:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 525;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 473;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 420;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 368;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 315;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 263;
                    }
                    break;

                case 5:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 578;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 520;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 462;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 405;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 347;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 289;
                    }
                    break;


                case 6:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 692;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 623;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 554;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 484;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 415;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 346;
                    }
                    break;

                default:
                    if (voziloZaRegistraciju.Premija == 0)
                    {
                        registracijaPutnickogVozila.Polisa = 831;
                    }
                    else if (voziloZaRegistraciju.Premija == 1)
                    {
                        registracijaPutnickogVozila.Polisa = 748;

                    }
                    else if (voziloZaRegistraciju.Premija == 2)
                    {
                        registracijaPutnickogVozila.Polisa = 665;
                    }
                    else if (voziloZaRegistraciju.Premija == 3)
                    {
                        registracijaPutnickogVozila.Polisa = 582;
                    }
                    else if (voziloZaRegistraciju.Premija == 4)
                    {
                        registracijaPutnickogVozila.Polisa = 499;
                    }
                    else
                    {
                        registracijaPutnickogVozila.Polisa = 416;
                    }
                    break;

            }

        }


        public void porezNaImovinu()
        {
            DateTime datum = DateTime.Now;
            int godina = datum.Year;

            if((godina - voziloZaRegistraciju.GodinaProizvodnje) > 7)
            {
                registracijaPutnickogVozila.Porez = 50;
            }
            else
            {
                if(voziloZaRegistraciju.Zapremina < 1600)
                {
                    registracijaPutnickogVozila.Porez = 80;
                }else if(voziloZaRegistraciju.Zapremina >= 1600 && voziloZaRegistraciju.Zapremina < 1800)
                {
                    registracijaPutnickogVozila.Porez = 100;

                }else if(voziloZaRegistraciju.Zapremina >= 1800 && voziloZaRegistraciju.Zapremina <= 2000)
                {
                    registracijaPutnickogVozila.Porez = 150;
                }
                else
                {
                    registracijaPutnickogVozila.Porez = 250;
                }
            }

        }
    }

 


    public class registracija
    {
        private int _polisa;
        private int _vodoprivreda;
        private int _bihamk;
        private int _porez;

        public registracija()
        {
            _vodoprivreda = 20;
            _bihamk = 8;
           
        }

        public int Polisa
        {
            get { return _polisa; }
            set { _polisa = value; }
        }

        public int Vodoprivreda
        {
            get { return _vodoprivreda; }
        }

        public int Bihamk
        {
            get { return _bihamk;}
        }

        public int Porez
        {
            get { return _porez; }
            set { _porez = value; }
        }


    }

}