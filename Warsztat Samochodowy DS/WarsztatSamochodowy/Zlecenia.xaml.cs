using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using WarsztatSamochodowy.Models;
using WarsztatSamochodowy.Komunikacja;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for Zlecenia.xaml
    /// </summary>
    public partial class Zlecenia : Window
    {
        Klienci klient = new Klienci();
        Samochody samochod = new Samochody();
        Uslugi usluga = new Uslugi();
        Pracownicy pracownik = new Pracownicy();
        Polaczenie pol = new Polaczenie();
        public Zlecenia()
        {
                InitializeComponent();         
                List<Klienci> klienci = pol.GetRESTKlient("http://warsztat-001-site1.etempurl.com/api/klient");
                int firstidK = klienci.Min(k => k.id_Klienta);
                int lastidK = klienci.Max(k => k.id_Klienta);

                List<Samochody> samochody = new List<Samochody>();
                List<Uslugi> uslugi = new List<Uslugi>();
                List<Pracownicy> pracownicy = pol.GetRESTPRacownik("http://warsztat-001-site1.etempurl.com/api/pracownik");

                for (int i = firstidK; i <= lastidK; i++)
                {
                    samochody.AddRange(pol.GetRESTSamochod("http://warsztat-001-site1.etempurl.com/api/samochod/" + i));
                }
            int fistidS = samochody.Min(s => s.id_Samochodu);
            int lastidS = samochody.Max(s => s.id_Samochodu);
            try
            {
                for (int i = fistidS; i <= lastidS; i++)
                {
                    uslugi.AddRange(pol.GetRESTUsluga("http://warsztat-001-site1.etempurl.com/api/usluga/" + i));
                }
            }
            catch { }
            var result2 =
                from pracownik in pracownicy
                select new
                {
                    pracownik.nrTelefonu,
                    pracownik.NazwiskoPracownika
                };
            var result =
            from klient in klienci
            join samochod in samochody on klient.id_Klienta equals samochod.id_Klienta
            join usluga in uslugi on samochod.id_Samochodu equals usluga.id_Samochodu
         //   into UslugiJoin
          //  from usluga in UslugiJoin.DefaultIfEmpty()
           join pracownik in pracownicy on usluga.id_Pracownika equals pracownik.id_Pracownika
            select new
            {

                klient.Imie,
                klient.Nazwisko,
                klient.Telefon,
                klient.id_Klienta,
                samochod.Marka,
                samochod.Model,
                usluga.Status,
                usluga.Podsumowanie,
                usluga.Opis_Usterek,
                usluga.Cena,
                pracownik.NazwiskoPracownika,
                pracownik.nrTelefonu,
                
              
            //   Status = usluga?.Status,
            //   Opis_Usterek=usluga?.Opis_Usterek,
           //    Podsumowanie=usluga?.Podsumowanie,
           //    Cena=usluga?.Cena,
            //   pracownik.NazwiskoPracownika
             // NazwiskoPracownika = pracwonik == null ? null: pracwonik.NazwiskoPracownika
            };

                foreach (var s in result)
                {
                    lvUsers.ItemsSource = result;

                
                 }
           
        }
     
          private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Close();
            }
        }

        private void btnParagon_Click(object sender, RoutedEventArgs e)
        {
            DaneParagonu paragon = new DaneParagonu();
            paragon.Show();
        }
    }
}
