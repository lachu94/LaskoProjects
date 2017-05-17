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
using System.Windows.Shapes;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for Formularz.xaml
    /// </summary>
    public partial class Formularz : Window
    {
        public List<Klienci> GetRESTKlient(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Klienci>>(s);

        }
        public List<Samochody> GetRESTSamochod(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Samochody>>(s);

        }

        public List<Uslugi> GetRESTUslugi(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uslugi>>(s);

        }



        public Formularz()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string telefon = txtTelefon.Text;

            if (imie.Length > 0)
            {
                if (nazwisko.Length > 0)
                {
                    if (telefon.Length > 0)
                    {
                        PostRESTKlienci("http://warsztat-001-site1.etempurl.com/api/klient", new Klienci() { Imie = imie, Nazwisko = nazwisko, Telefon = telefon });
                    }
                }
            }

            string model = txtModel.Text;
            string marka = txtMarka.Text;
            string typSilnika = cboxTypSilnika.Text;

            List<Klienci> klienci = GetRESTKlient("http://warsztat-001-site1.etempurl.com/api/klient");
            int idSamochodu = 0;
            int idUslugi = 0;
            int id = 0;
            int length = klienci.Count;

            foreach (var k in klienci)
            {
                // if (r.Login.Equals(txtLogin.Text) && r.Haslo.Equals(txtHaslo.Text))
                if (String.Compare(txtImie.Text, k.Imie, false) == 0 && String.Compare(txtNazwisko.Text, k.Nazwisko, false) == 0)
                {

                    //Samochód
                    id = k.id_Klienta;
                    MessageBox.Show("ID " + id);

                    if (model.Length > 0)
                    {
                        if (marka.Length > 0)
                        {
                            if (typSilnika.Length > 0)
                            {
                                PostRESTSamochody("http://warsztat-001-site1.etempurl.com/api/samochod/" , new Samochody() { Marka = marka, Model = model, Typ_silnika = typSilnika , id_Klienta=id } );
                            }
                        }
                    }
                        
                    List<Samochody> samochody = GetRESTSamochod("http://warsztat-001-site1.etempurl.com/api/samochod/"+ id);
                    foreach (var s in samochody)
                    {
                        if (String.Compare(id.ToString(), s.id_Klienta.ToString(),false)==0)
                        {
                            idSamochodu = s.id_Samochodu;
                        }
                    }
                    //Usluga
                    string opisUsterki = txtOpisUsterki.Text;
                    if (opisUsterki.Length > 0)
                    {
                        PostRESTUslugi("http://warsztat-001-site1.etempurl.com/api/usluga/", new Uslugi() { Opis_Usterek = opisUsterki, id_Samochodu = idSamochodu,id_Pracownika=1, Status = "Przyjęte", Podsumowanie = null, Cena = 0 });
                    }


                    List<Uslugi> uslugi = GetRESTUslugi("http://warsztat-001-site1.etempurl.com/api/usluga/" + idSamochodu);
                    foreach (var u in uslugi)
                    {
                        if (String.Compare(idSamochodu.ToString(), u.id_Samochodu.ToString(), false) == 0)
                        {
                            idUslugi = u.id_Uslugi;
                        }
                    }                  
                                       
                 }
            }                   
                   
        }

        private void PostRESTKlienci(string uri, Klienci k)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(k);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
        }

        private void PostRESTSamochody(string uri, Samochody s )
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(s);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
        }

        private void PostRESTUslugi(string uri, Uslugi u)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(u);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            
           
            mm.Show();
            this.Close();
        }
    }
}
