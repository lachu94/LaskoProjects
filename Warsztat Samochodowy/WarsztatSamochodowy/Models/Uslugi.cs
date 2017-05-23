using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace WarsztatSamochodowy.Models
{
    public partial class Uslugi
    {
        public int id_Uslugi { get; set; }
        public string Opis_Usterek { get; set; }
        public int id_Samochodu { get; set; }
        public int id_Pracownika { get; set; }
        public string Status { get; set; }
        public string Podsumowanie { get; set; }
        public double Cena { get; set; }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", id_Uslugi, Opis_Usterek, id_Samochodu, id_Pracownika);
        }
        public List<Uslugi> GetRESTUsluga(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uslugi>>(s);
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
    }
}
