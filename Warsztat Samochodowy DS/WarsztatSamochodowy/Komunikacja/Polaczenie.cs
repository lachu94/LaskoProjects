using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using WarsztatSamochodowy.Models;

namespace WarsztatSamochodowy.Komunikacja
{
   public sealed class Polaczenie : IPolaczenie
    {
        public List<Klienci> GetRESTKlient(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Klienci>>(s);
        }

        public List<Pracownicy> GetRESTPRacownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Pracownicy>>(s);
        }

        public List<Samochody> GetRESTSamochod(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Samochody>>(s);
        }

        public List<Uslugi> GetRESTUsluga(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uslugi>>(s);
        }

        public List<Uzytkownicy> GetRESTUzytkownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uzytkownicy>>(s);
        }

        public int PostRESTKlienci(string uri, Klienci k)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(k);
            sw.Write(json);
            sw.Close();

            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                string resultstring = result.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Klienci ks = js.Deserialize(resultstring, typeof(Klienci)) as Klienci;
                int idk = ks.id_Klienta;
                return idk;

            }
        }

        public int PostRESTPracownicy(string uri, Pracownicy s)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(s);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                string resultstring = result.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Pracownicy p = js.Deserialize(resultstring, typeof(Pracownicy)) as Pracownicy;
                int idp = p.id_Pracownika;
                return idp;

            }
        }

        public int PostRESTSamochody(string uri, Samochody s)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(s);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                string resultstring = result.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Samochody sm = js.Deserialize(resultstring, typeof(Samochody)) as Samochody;
                int ids = sm.id_Samochodu;
                return ids;

            }
        }

        public int PostRESTUslugi(string uri, Uslugi u)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(u);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                string resultstring = result.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Uslugi us = js.Deserialize(resultstring, typeof(Uslugi)) as Uslugi;
                int idu = us.id_Uslugi;
                return idu;
            }
        }

        public int PostRESTUzytkownicy(string uri, Uzytkownicy s)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            StreamWriter sw = new StreamWriter(webRequest.GetRequestStream());
            string json = JsonConvert.SerializeObject(s);
            sw.Write(json);
            sw.Close();
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                string resultstring = result.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Uzytkownicy u = js.Deserialize(resultstring, typeof(Uzytkownicy)) as Uzytkownicy;
                int idu = u.id_Uzytkownika;
                return idu;

            }
        }
    }
}
