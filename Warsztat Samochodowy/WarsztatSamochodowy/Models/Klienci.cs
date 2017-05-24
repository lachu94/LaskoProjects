using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WarsztatSamochodowy.Models
{
    public partial class Klienci
    {
        public int id_Klienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", id_Klienta, Imie, Nazwisko, Telefon);
        }
        public List<Klienci> GetRESTKlient(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Klienci>>(s);
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
    }
}
