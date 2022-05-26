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
        public dodatneOpcije dodatneOpcijeZaReg;
        public Kalkulator3(putnickoVozilo vozilo, dodatneOpcije dodatneOpcijeZaRegistraciju)
        {
            InitializeComponent();
            registracijaPutnickogVozila = new registracija();
            voziloZaRegistraciju = vozilo;
            dodatneOpcijeZaReg = dodatneOpcijeZaRegistraciju;



            izracunajVrijednostPolise();
            porezNaImovinu();
            vrijednostPutarine();
            vrijednostEkologije();
            noveTablice();
            izgubljeneTablice();
            potvrde();
            tehnickiPlusEkotest();
            vrijednostTakse();
            brojSjedista();
            taxi();
            invalidi();
            ukupnaCijenaRegistracije();
  
             

            polisaIspis.Text = registracijaPutnickogVozila.Polisa.ToString();
            vodoprivredaIspis.Text = registracijaPutnickogVozila.Vodoprivreda.ToString();
            bihamkIspis.Text = registracijaPutnickogVozila.Bihamk.ToString();
            porezIspis.Text = registracijaPutnickogVozila.Porez.ToString();
            putarinaIspis.Text = registracijaPutnickogVozila.Putarina.ToString();
            ekologijaIspis.Text = registracijaPutnickogVozila.FondZaZastituOkolisa.ToString();
            noveTabliceIspis.Text = registracijaPutnickogVozila.NoveTablice.ToString();
            izgubljeneTabliceIspis.Text = registracijaPutnickogVozila.IzgubljeneTablice.ToString();
            potvrdaORegistracijiIspis.Text = registracijaPutnickogVozila.PotvrdaORegistraciji.ToString();
            potvrdaOVlasnistvuIspis.Text = registracijaPutnickogVozila.PotvrdaOVlasnistvu.ToString();
            stikerIspis.Text = registracijaPutnickogVozila.Stiker.ToString();
            tehnickiPregledIspis.Text = registracijaPutnickogVozila.TehnickiPregled.ToString();
            taksaIspis.Text = registracijaPutnickogVozila.Taksa.ToString();
            ukupnaCijenaRegistracijeIspis.Text = registracijaPutnickogVozila.UkupnaCijena.ToString();

            

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

        public void vrijednostPutarine()
        {
            if(voziloZaRegistraciju.Zapremina < 1001)
            {
                registracijaPutnickogVozila.Putarina = 48;
            }else if(voziloZaRegistraciju.Zapremina >= 1001 && voziloZaRegistraciju.Zapremina <= 1600)
            {
                registracijaPutnickogVozila.Putarina = 60;
            }else if (voziloZaRegistraciju.Zapremina >= 1601 && voziloZaRegistraciju.Zapremina <= 2000)
            {
                registracijaPutnickogVozila.Putarina = 75;
            }else if (voziloZaRegistraciju.Zapremina >= 2001 && voziloZaRegistraciju.Zapremina <= 2500)
            {
                registracijaPutnickogVozila.Putarina = 140.10;
            }
            else
            {
                registracijaPutnickogVozila.Putarina = 210;
            }


            if(voziloZaRegistraciju.VrstaGoriva == 2)
            {
                registracijaPutnickogVozila.Putarina = registracijaPutnickogVozila.Putarina + 0.25 * registracijaPutnickogVozila.Putarina;
            }
        }



        public void vrijednostEkologije()
        {
            int No = 15;
            double Pn;
            double K1, K2, K3;
            DateTime datum = DateTime.Now;
            int godina = datum.Year;

            int starostVozila = godina - voziloZaRegistraciju.GodinaProizvodnje;


            K1 = 1.0;

            if(voziloZaRegistraciju.Zapremina <= 50)
            {
                K2 = 0.8;
            }else if(voziloZaRegistraciju.Zapremina >= 51 && voziloZaRegistraciju.Zapremina <= 250)
            {
                K2 = 0.85;
            }else if(voziloZaRegistraciju.Zapremina >= 251 && voziloZaRegistraciju.Zapremina <= 750)
            {
                K2 = 0.9;
            }else if(voziloZaRegistraciju.Zapremina >= 751 && voziloZaRegistraciju.Zapremina <= 1400)
            {
                K2 = 0.95;
            }else if(voziloZaRegistraciju.Zapremina >= 1401 && voziloZaRegistraciju.Zapremina <= 2000)
            {
                K2 = 1.0;
            }else if(voziloZaRegistraciju.Zapremina >= 2001 && voziloZaRegistraciju.Zapremina <= 4000)
            {
                K2 = 1.2;
            }else if(voziloZaRegistraciju.Zapremina >= 4001 && voziloZaRegistraciju.Zapremina <= 8000)
            {
                K2 = 1.4;
            }else if(voziloZaRegistraciju.Zapremina >= 8001 && voziloZaRegistraciju.Zapremina <= 12000)
            {
                K2 = 1.6;
            }else if(voziloZaRegistraciju.Zapremina >= 12001 && voziloZaRegistraciju.Zapremina <= 16000)
            {
                K2 = 1.8;
            }
            else
            {
                K2 = 2.0;
            }



            if(starostVozila <= 5)
            {
                K3 = 0.9;
            }else if(starostVozila >= 6 && starostVozila <= 8)
            {
                K3 = 0.95;
            }else if(starostVozila >= 9 && starostVozila <= 10)
            {
                K3 = 1.0;
            }else if(starostVozila >= 11 && starostVozila <= 15)
            {
                K3 = 1.1;
            }else if(starostVozila >= 16 && starostVozila <= 20)
            {
                K3 = 1.2;
            }else if(starostVozila >= 21 && starostVozila <= 30)
            {
                K3 = 1.4;
            }
            else
            {
                K3 = 1.6;
            }


            Pn = No * K1 * K2 * K3;

            registracijaPutnickogVozila.FondZaZastituOkolisa = Pn;

        }



        public void noveTablice()
        {
            if(voziloZaRegistraciju.VrstaRegistracije == 0)
            {
                dodatneOpcijeZaReg.registarskeTablice = true;
            }


            if (dodatneOpcijeZaReg.registarskeTablice)
            {
                registracijaPutnickogVozila.NoveTablice = 20;
            }
        }


        public void izgubljeneTablice()
        {
            if (dodatneOpcijeZaReg.izgubljeneTablice)
            {
                registracijaPutnickogVozila.IzgubljeneTablice = 40;

            }
        }


        public void potvrde()
        {
            if(voziloZaRegistraciju.VrstaRegistracije == 0)
            {
                dodatneOpcijeZaReg.potvrdaORegistraciji = true;
                dodatneOpcijeZaReg.potvrdaOVlasnistvu = true;
            }

            if(voziloZaRegistraciju.VrstaRegistracije == 2)
            {
                dodatneOpcijeZaReg.potvrdaORegistraciji = true;

            }

            if (dodatneOpcijeZaReg.potvrdaOVlasnistvu)
            {
                registracijaPutnickogVozila.PotvrdaOVlasnistvu = 5;
            }

            if (dodatneOpcijeZaReg.potvrdaORegistraciji)
            {
                registracijaPutnickogVozila.PotvrdaORegistraciji = 5;
            }
        }


        public void tehnickiPlusEkotest()
        {
            if(voziloZaRegistraciju.VrstaGoriva == 0)
            {
                registracijaPutnickogVozila.TehnickiPregled += 22;
            }else if(voziloZaRegistraciju.VrstaGoriva == 1)
            {
                registracijaPutnickogVozila.TehnickiPregled += 36;
            }
            else
            {
                registracijaPutnickogVozila.TehnickiPregled += 32;
            }
        }

        public void vrijednostTakse()
        {
            if(voziloZaRegistraciju.VrstaRegistracije == 0 || dodatneOpcijeZaReg.potvrdaORegistraciji || dodatneOpcijeZaReg.potvrdaOVlasnistvu)
            {
                registracijaPutnickogVozila.Taksa = 20;
            }
            else
            {
                registracijaPutnickogVozila.Taksa = 10;
            }
        }


        public void brojSjedista()
        {
            if(dodatneOpcijeZaReg.BrojPutnika > 5)
            {
                registracijaPutnickogVozila.Polisa += registracijaPutnickogVozila.Polisa * 0.1;
            }
        }

        public void ukupnaCijenaRegistracije()
        {
            double ukupnaCijena;

            ukupnaCijena = registracijaPutnickogVozila.Polisa +
                registracijaPutnickogVozila.Vodoprivreda +
                registracijaPutnickogVozila.Bihamk +
                registracijaPutnickogVozila.Porez +
                registracijaPutnickogVozila.Putarina +
                registracijaPutnickogVozila.FondZaZastituOkolisa +
                registracijaPutnickogVozila.NoveTablice +
                registracijaPutnickogVozila.IzgubljeneTablice +
                registracijaPutnickogVozila.PotvrdaORegistraciji +
                registracijaPutnickogVozila.PotvrdaOVlasnistvu +
                registracijaPutnickogVozila.Stiker +
                registracijaPutnickogVozila.TehnickiPregled +
                registracijaPutnickogVozila.Taksa;

            registracijaPutnickogVozila.UkupnaCijena = ukupnaCijena;
        }

        public void taxi()
        {
            if (dodatneOpcijeZaReg.taxiVozilo)
            {
                registracijaPutnickogVozila.Polisa += registracijaPutnickogVozila.Polisa * 0.4;
            }
        }


        public void invalidi()
        {
            if (dodatneOpcijeZaReg.popustZaInvalide)
            {
                registracijaPutnickogVozila.Polisa -= registracijaPutnickogVozila.Polisa * 0.1;
                registracijaPutnickogVozila.Putarina = 0;
                registracijaPutnickogVozila.Porez = 0;

            }
        }



    }

 


    public class registracija
    {
        private double _polisa;
        private int _vodoprivreda;
        private int _bihamk;
        private int _porez;
        private double _putarina;
        private double _fondZaZastituOkolisa;
        private int _noveTablice;
        private int _izgubljeneTablice;
        private int _potvrdaORegistraciji;
        private int _potvrdaOVlasnistvu;
        private int _stiker;
        private int _tehnickiPregled;
        private int _taksa;
        private double _ukupnaCijena;

        public registracija()
        {
            _vodoprivreda = 20;
            _bihamk = 8;
            _stiker = 5;
            _tehnickiPregled = 55;
           
        }

        public double Polisa
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

        public double Putarina
        {
            get { return _putarina; }
            set { _putarina = value; }
        }

        public double FondZaZastituOkolisa
        {
            get { return _fondZaZastituOkolisa;}
            set { _fondZaZastituOkolisa = value; }
        }

        public int NoveTablice
        {
            get { return _noveTablice;}
            set { _noveTablice = value; }
        }

        public int IzgubljeneTablice
        {
            get { return _izgubljeneTablice; }
            set { _izgubljeneTablice = value; }
        }

        public int PotvrdaORegistraciji
        {
            get { return _potvrdaORegistraciji; }
            set { _potvrdaORegistraciji = value; }
        }

        public int PotvrdaOVlasnistvu
        {
            get { return _potvrdaOVlasnistvu; }
            set { _potvrdaOVlasnistvu = value; }
        }

        public int Stiker
        {
            get { return _stiker; }
            set { _stiker = value; }
        }

        public int TehnickiPregled
        {
            get { return _tehnickiPregled; }
            set { _tehnickiPregled = value; }

        }

        public int Taksa
        {
            get { return _taksa; }
            set { _taksa = value; }
        }

        public double UkupnaCijena
        {
            get { return _ukupnaCijena; }
            set { _ukupnaCijena = value; }
        }





    }

}