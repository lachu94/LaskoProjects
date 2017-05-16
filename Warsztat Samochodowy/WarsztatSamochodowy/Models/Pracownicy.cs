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
    public partial class Pracownicy
    {
        public int id_Pracownika { get; set; }
        public string Imie { get; set; }

        [JsonProperty("Nazwisko")]
        public string NazwiskoPracownika { get; set; }
        public string nrTelefonu { get; set; }
        public List<Pracownicy> GetRESTPRacownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Pracownicy>>(s);
        }
    }
}
