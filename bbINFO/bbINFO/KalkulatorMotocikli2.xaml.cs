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
    public partial class KalkulatorMotocikli2 : ContentPage
    {
        public motocikli motociklZaRegistraciju;
        public dodatneOpcijeZaMotocikl dodatneOpcijeZaRegistracijuMotocikla;
        public registracijaMotocikla registracijaMotocikla;
        public KalkulatorMotocikli2(motocikli motocikl, dodatneOpcijeZaMotocikl dodatneOpcije)
        {
            InitializeComponent();
            motociklZaRegistraciju = motocikl;
            dodatneOpcijeZaRegistracijuMotocikla = dodatneOpcije;
            registracijaMotocikla = new registracijaMotocikla();

            vrijednostPoliseMotocikla();
            vrijednostPorezaMotocikla();
            vrijednostPutarineMotocikla();
            vrijednostFondaZaZastituOkolisa();
            noveTabliceZaMotocikl();
            izgubljeneTabliceMotocikla();
            potvrdeZaMotocikl();
            vrijednostTehnickogPregledaMotocikla();
            vrijednostTakse();
            zeleniKartonZaMotocikl();
            ukupnaCijena();

            polisaIspis.Text = registracijaMotocikla.Polisa.ToString() + " KM";
            vodoprivreda.Text = registracijaMotocikla.Vodoprivreda.ToString() + " KM";
            bihamkIspis.Text = registracijaMotocikla.Bihamk.ToString() + " KM";
            porezIspis.Text = registracijaMotocikla.Porez.ToString() + " KM";
            putarinaIspis.Text = registracijaMotocikla.Putarina.ToString() + " KM";
            okolisIspis.Text = registracijaMotocikla.FondZaZastituOkolisa.ToString() + " KM";
            noveTabliceIspis.Text = registracijaMotocikla.NoveTablice.ToString() + " KM";
            izgubljeneTabliceIspis.Text = registracijaMotocikla.IzgubljeneTablice.ToString() + " KM";
            potvrdaORegistracijiIspis.Text = registracijaMotocikla.PotvrdaORegistraciji.ToString() + " KM";
            potvrdaOVlasnistvuIspis.Text = registracijaMotocikla.PotvrdaOVlasnistvu.ToString() + " KM";
            stikerIspis.Text = registracijaMotocikla.Stiker.ToString() + " KM";
            tehnickiIspis.Text = registracijaMotocikla.TehnickiPregled.ToString() + " KM";
            taksaIspis.Text = registracijaMotocikla.Taksa.ToString() + " KM";
            zeleniKartonIspis.Text = registracijaMotocikla.ZeleniKarton.ToString() + " KM";
            ukupnaIspis.Text = registracijaMotocikla.UkupnaCijena.ToString() + " KM";
            
            





        }

        public void vrijednostPoliseMotocikla()
        {
            switch (motociklZaRegistraciju.Zapremina)
            {
                case 0:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 33;
                    }else if(motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 30;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 26;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 23;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 20;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 17;
                    }
                    break;

                 case 1:
                        if (motociklZaRegistraciju.Premija == 0)
                        {
                            registracijaMotocikla.Polisa = 63;
                        }
                        else if (motociklZaRegistraciju.Premija == 1)
                        {
                            registracijaMotocikla.Polisa = 57;
                        }
                        else if (motociklZaRegistraciju.Premija == 2)
                        {
                            registracijaMotocikla.Polisa = 50;
                        }
                        else if (motociklZaRegistraciju.Premija == 3)
                        {
                            registracijaMotocikla.Polisa = 44;
                        }
                        else if (motociklZaRegistraciju.Premija == 4)
                        {
                            registracijaMotocikla.Polisa = 38;
                        }
                        else
                        {
                            registracijaMotocikla.Polisa = 32;
                        }
                        break;

                case 2:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 84;
                    }
                    else if (motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 76;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 67;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 59;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 50;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 42;
                    }
                    break;

                case 3:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 108;
                    }
                    else if (motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 97;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 86;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 76;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 65;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 54;
                    }
                    break;

                case 4:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 189;
                    }
                    else if (motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 170;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 151;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 132;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 113;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 95;
                    }
                    break;

                case 5:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 365;
                    }
                    else if (motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 329;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 292;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 256;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 219;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 183;
                    }
                    break;

                default:
                    if (motociklZaRegistraciju.Premija == 0)
                    {
                        registracijaMotocikla.Polisa = 551;
                    }
                    else if (motociklZaRegistraciju.Premija == 1)
                    {
                        registracijaMotocikla.Polisa = 496;
                    }
                    else if (motociklZaRegistraciju.Premija == 2)
                    {
                        registracijaMotocikla.Polisa = 441;
                    }
                    else if (motociklZaRegistraciju.Premija == 3)
                    {
                        registracijaMotocikla.Polisa = 386;
                    }
                    else if (motociklZaRegistraciju.Premija == 4)
                    {
                        registracijaMotocikla.Polisa = 331;
                    }
                    else
                    {
                        registracijaMotocikla.Polisa = 276;
                    }
                    break;
            }
        }

        public void vrijednostPorezaMotocikla()
        {
            DateTime datum = DateTime.Now;
            int godina = datum.Year;

            if(godina - motociklZaRegistraciju.GodinaProizvodnje < 7)
            {
                if(motociklZaRegistraciju.Zapremina == 0)
                {
                    registracijaMotocikla.Porez = 50;
                }
                else
                {
                    registracijaMotocikla.Porez = 100;
                }

            }
            else
            {
                registracijaMotocikla.Porez = 0;
            }
        }


        public void vrijednostPutarineMotocikla()
        {
            double GN, ON, K;
            ON = 30.00;

            if(motociklZaRegistraciju.Kategorija == 0 || motociklZaRegistraciju.Kategorija == 1 || motociklZaRegistraciju.Kategorija == 5)
            {
                K = 1.2;
            }
            else
            {
                K = 1.6;
            }

            GN = ON * K;
            registracijaMotocikla.Putarina = GN;
        }

        public void vrijednostFondaZaZastituOkolisa()
        {
            int No;
            double Pn;
            double K1, K2, K3;
            DateTime datum = DateTime.Now;
            int godina = datum.Year;
            int starostMotocikla = godina - motociklZaRegistraciju.GodinaProizvodnje;

            if(motociklZaRegistraciju.Kategorija == 0 || motociklZaRegistraciju.Kategorija == 1 || motociklZaRegistraciju.Kategorija == 5)
            {
                No = 6;
            }
            else
            {
                No = 10;
            }


            if(motociklZaRegistraciju.VrstaMotora == 0)
            {
                K1 = 2.0;
            }
            else
            {
                K1 = 1.0;
            }



            if (motociklZaRegistraciju.Zapremina == 0)
            {
                K2 = 0.8;
            }else if(motociklZaRegistraciju.Zapremina == 1 || motociklZaRegistraciju.Zapremina == 2 || motociklZaRegistraciju.Zapremina == 3)
            {
                K2 = 0.85;
            }else if(motociklZaRegistraciju.Zapremina == 4 || motociklZaRegistraciju.Zapremina == 5)
            {
                K2 = 0.90;
            }
            else
            {
                K2 = 0.95;
            }



            if (starostMotocikla <= 5)
            {
                K3 = 0.9;
            }
            else if (starostMotocikla >= 6 && starostMotocikla <= 8)
            {
                K3 = 0.95;
            }
            else if (starostMotocikla >= 9 && starostMotocikla <= 10)
            {
                K3 = 1.0;
            }
            else if (starostMotocikla >= 11 && starostMotocikla <= 15)
            {
                K3 = 1.1;
            }
            else if (starostMotocikla >= 16 && starostMotocikla <= 20)
            {
                K3 = 1.2;
            }
            else if (starostMotocikla >= 21 && starostMotocikla <= 30)
            {
                K3 = 1.4;
            }
            else
            {
                K3 = 1.6;
            }


            Pn = No * K1 * K2 * K3;

            registracijaMotocikla.FondZaZastituOkolisa = Pn;



        }


        public void noveTabliceZaMotocikl()
        {
            if (motociklZaRegistraciju.VrstaRegistracije == 0)
            {
                dodatneOpcijeZaRegistracijuMotocikla.registarskeTablice = true;
            }


            if (dodatneOpcijeZaRegistracijuMotocikla.registarskeTablice)
            {
                registracijaMotocikla.NoveTablice = 20;
            }
        }

        public void izgubljeneTabliceMotocikla()
        {
            if (dodatneOpcijeZaRegistracijuMotocikla.izgubljeneTablice)
            {
                registracijaMotocikla.IzgubljeneTablice = 40;

            }
        }

        public void potvrdeZaMotocikl()
        {
            if (motociklZaRegistraciju.VrstaRegistracije == 0)
            {
                dodatneOpcijeZaRegistracijuMotocikla.potvrdaORegistraciji = true;
                dodatneOpcijeZaRegistracijuMotocikla.potvrdaOVlasnistvu = true;
            }

            if (motociklZaRegistraciju.VrstaRegistracije == 2)
            {
                dodatneOpcijeZaRegistracijuMotocikla.potvrdaORegistraciji = true;

            }

            if (dodatneOpcijeZaRegistracijuMotocikla.potvrdaOVlasnistvu)
            {
                registracijaMotocikla.PotvrdaOVlasnistvu = 5;
            }

            if (dodatneOpcijeZaRegistracijuMotocikla.potvrdaORegistraciji)
            {
                registracijaMotocikla.PotvrdaORegistraciji = 5;
            }
        }

        public void vrijednostTehnickogPregledaMotocikla()
        {
            if(motociklZaRegistraciju.Kategorija == 0 || motociklZaRegistraciju.Kategorija == 1 || motociklZaRegistraciju.Kategorija == 2 || motociklZaRegistraciju.Kategorija == 3
                || motociklZaRegistraciju.Kategorija == 4)
            {
                registracijaMotocikla.TehnickiPregled = 36.16;
            }
            else
            {
                registracijaMotocikla.TehnickiPregled = 42;
            }
        }

        public void vrijednostTakse()
        {
            if (motociklZaRegistraciju.VrstaRegistracije == 0 || dodatneOpcijeZaRegistracijuMotocikla.potvrdaORegistraciji || dodatneOpcijeZaRegistracijuMotocikla.potvrdaOVlasnistvu)
            {
                registracijaMotocikla.Taksa = 20;
            }
            else
            {
                registracijaMotocikla.Taksa = 10;
            }
        }

        public void zeleniKartonZaMotocikl()
        {
            if (dodatneOpcijeZaRegistracijuMotocikla.zeleniKarton)
            {
                registracijaMotocikla.ZeleniKarton = 4;
            }
        }


        public void ukupnaCijena()
        {
            double ukupnaCijenaRegistracije;

            ukupnaCijenaRegistracije = registracijaMotocikla.Polisa +
                registracijaMotocikla.Vodoprivreda +
                registracijaMotocikla.Bihamk +
                registracijaMotocikla.Porez +
                registracijaMotocikla.Putarina +
                registracijaMotocikla.FondZaZastituOkolisa +
                registracijaMotocikla.NoveTablice +
                registracijaMotocikla.IzgubljeneTablice +
                registracijaMotocikla.PotvrdaORegistraciji +
                registracijaMotocikla.PotvrdaOVlasnistvu +
                registracijaMotocikla.Stiker +
                registracijaMotocikla.TehnickiPregled +
                registracijaMotocikla.Taksa +
                registracijaMotocikla.ZeleniKarton;

            registracijaMotocikla.UkupnaCijena = ukupnaCijenaRegistracije;
        }


    }


    public class registracijaMotocikla
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
        private double _tehnickiPregled;
        private int _taksa;
        private int _zeleniKarton;
        private double _ukupnaCijena;

        public registracijaMotocikla()
        {
            _vodoprivreda = 20;
            _bihamk = 8;
            _stiker = 5;

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
            get { return _bihamk; }
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
            get { return _fondZaZastituOkolisa; }
            set { _fondZaZastituOkolisa = value; }
        }

        public int NoveTablice
        {
            get { return _noveTablice; }
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

        public double TehnickiPregled
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

        public int ZeleniKarton
        {
            get { return _zeleniKarton; }
            set { _zeleniKarton = value; }
        }





    }
}