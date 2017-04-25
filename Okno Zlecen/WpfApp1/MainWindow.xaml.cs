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
            
            
            List<Klient> klient = GetRESTTowary("http://warsztat-001-site1.etempurl.com/api/klient");
            int firstidK = klient.Min(k => k.id_Klienta);
            int lastidK = klient.Max(k => k.id_Klienta);
            List<Samochod> samochod = new List<Samochod>();
            List<Usluga> usluga = new List<Usluga>();
            List<Pracownik> pracownik = GetRESTPRacownik("http://warsztat-001-site1.etempurl.com/api/pracownik");
            MessageBox.Show("dd " );
            for (int i = firstidK; i <= lastidK; i++)
            {
               samochod.AddRange(GetRESTSamochod("http://warsztat-001-site1.etempurl.com/api/samochod/" +i));
            }
            for (int i = firstidK; i <= 10; i++)
            {
                usluga.AddRange(GetRESTUsluga("http://warsztat-001-site1.etempurl.com/api/usluga/" + i));
            }

    

            var resutl=
            from d in klient
            join c in samochod on d.id_Klienta equals c.id_Klienta
            join s in usluga on c.id_Samochodu equals s.id_Samochodu
            //into a
            //from j in a.DefaultIfEmpty()
            join p in pracownik on s.id_Pracownika equals p.id_Pracownika
            //into q
            //from o in q.DefaultIfEmpty()
            select new
              {
             
                 d.Imie,
                 d.Nazwisko,
                 d.Telefon,
                 d.id_Klienta,
                 c.Marka,
                 c.Model,
                 s.Status,
                 p.nrTelefonu
                // Status= j?.Status,
                // nrTelefonu =o?.nrTelefonu


            };

            foreach (var s in resutl)
            {
               lvUsers.ItemsSource = resutl;
              

            }



        }

        public class Klient
        {
            public int id_Klienta { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Telefon { get; set; }
        
        }
        public class Samochod
        {
            public int id_Samochodu { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Typ_silnika { get; set; }
            public int id_Klienta { get; set; }
        }
        public class Pracownik
        {
            public int id_Pracownika { get; set; }
            public string Imie { get; set; }
            [JsonProperty ("Nazwisko")]
            public string NazwiskoPracownika { get; set; }
            public string nrTelefonu { get; set; }
        }

        public class Usluga
        {
            public int id_Uslugi { get; set; }
            public string Opis_Usterek { get; set; }
            public int id_Samochodu { get; set; }
            public int id_Pracownika { get; set; }
            public string Status { get; set; }
        }
     

        private List<Klient> GetRESTTowary(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Klient>>(s);
        }
        private List<Samochod> GetRESTSamochod(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Samochod>>(s);
        }
        private List<Pracownik> GetRESTPRacownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Pracownik>>(s);
        }
        private List<Usluga> GetRESTUsluga(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Usluga>>(s);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
