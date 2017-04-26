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

            //string model = txtModel.Text;
            //string marka = txtMarka.Text;
            //string typSilnika = cboxTypSilnika.Text;

            //if (model.Length > 0)
            //{
            //    if (marka.Length > 0)
            //    {
            //        if (typSilnika.Length > 0)
            //        {
            //            PostRESTSamochody("http://warsztat-001-site1.etempurl.com/api/samochod/4", new Samochody() { Marka = marka, Model = model, Typ_silnika = typSilnika });
            //        }
            //    }
            //}


            string opisUsterki = txtOpisUsterki.Text;
            if (opisUsterki.Length > 0)
            {
                PostRESTUslugi("http://warsztat-001-site1.etempurl.com/api/usluga", new Uslugi() { Opis_Usterek = opisUsterki });
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

        //private void PostRESTSamochody(string uri, Samochody s)
        //{
        //    var webRequest = (HttpWebRequest)WebRequest.Create(uri);
        //    webRequest.ContentType = "application/json";
        //    webRequest.Method = "POST";
        //    StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
        //    string json = JsonConvert.SerializeObject(s);
        //    sw.Write(json);
        //    sw.Close();
        //    var webResponse = (HttpWebResponse)webRequest.GetResponse();
        //}

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
    }
}
