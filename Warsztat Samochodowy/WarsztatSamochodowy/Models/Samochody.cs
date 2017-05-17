using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy.Models
{
    public partial class Samochody
    {
        public int id_Samochodu { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Typ_silnika { get; set; }
        public int id_Klienta { get; set; }
        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", id_Samochodu, Marka, Model, Typ_silnika, id_Klienta);
        }
        public List<Samochody> GetRESTSamochod(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Samochody>>(s);
        }
        public void PostRESTSamochody(string uri, Samochody s)
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
    }
}
