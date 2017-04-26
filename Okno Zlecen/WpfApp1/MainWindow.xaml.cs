using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<Klienci> klienci = GetRESTTowary("http://warsztat-001-site1.etempurl.com/api/klient");
            int firstidK = klienci.Min(k => k.id_Klienta);
            int lastidK = klienci.Max(k => k.id_Klienta);
            List<Samochody> samochody = new List<Samochody>();
            List<Uslugi> uslugi = new List<Uslugi>();
            List<Pracownicy> pracownicy = GetRESTPRacownik("http://warsztat-001-site1.etempurl.com/api/pracownik");

            for (int i = firstidK; i <= lastidK; i++)
            {
                samochody.AddRange(GetRESTSamochod("http://warsztat-001-site1.etempurl.com/api/samochod/" + i));
            }
            for (int i = firstidK; i <= 10; i++)
            {
                uslugi.AddRange(GetRESTUsluga("http://warsztat-001-site1.etempurl.com/api/usluga/" + i));
            }

            var result =
            from klient in klienci
            join samochod in samochody on klient.id_Klienta equals samochod.id_Klienta
            join usluga in uslugi on samochod.id_Samochodu equals usluga.id_Samochodu
            into UslugiJoin
            from usluga in UslugiJoin.DefaultIfEmpty()

                //join pracownicy in pracownik on new { Id_Pracownika = uslugi.id_Pracownika }
                //      equals new { Id_Pracownika = pracownicy.id_Pracownika } into Pracownicy_join
                //from pracownicy in Pracownicy_join.DefaultIfEmpty()
                //from k in klient
                //from s in samochod.Where(c => k.id_Klienta == c.id_Klienta)
                //from u in usluga.Where(j => s.id_Samochodu == j.id_Samochodu).DefaultIfEmpty()
                //from p in pracownik.Where(a => u.id_Pracownika == a.id_Pracownika).DefaultIfEmpty()
                //from u1 in usluga
            select new
            {

                klient.Imie,
                klient.Nazwisko,
                klient.Telefon,
                klient.id_Klienta,
                samochod.Marka,
                samochod.Model,
                Status = usluga?.Status,
                //  NazwiskoPracownika = pracownicy == null ? null: pracownicy.NazwiskoPracownika
            };

            foreach (var s in result)
            {
                lvUsers.ItemsSource = result;

            }
        }

        public class Klienci
        {
            public int id_Klienta { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Telefon { get; set; }

        }
        public class Samochody
        {
            public int id_Samochodu { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Typ_silnika { get; set; }
            public int id_Klienta { get; set; }
        }
        public class Pracownicy
        {
            public int id_Pracownika { get; set; }
            public string Imie { get; set; }
            [JsonProperty("Nazwisko")]
            public string NazwiskoPracownika { get; set; }
            public string nrTelefonu { get; set; }

        }

        public class Uslugi
        {
            public int id_Uslugi { get; set; }
            public string Opis_Usterek { get; set; }
            public int id_Samochodu { get; set; }
            public int id_Pracownika { get; set; }
            public string Status { get; set; }
        }


        private List<Klienci> GetRESTTowary(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Klienci>>(s);
        }
        private List<Samochody> GetRESTSamochod(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Samochody>>(s);
        }
        private List<Pracownicy> GetRESTPRacownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Pracownicy>>(s);
        }
        private List<Uslugi> GetRESTUsluga(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uslugi>>(s);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Close();
            }
        }
    }
}
