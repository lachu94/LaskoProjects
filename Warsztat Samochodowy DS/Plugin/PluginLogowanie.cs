using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Plugin
{
    public class PluginLogowanie : IPluginLogowanie
    {
        public string Login(string login, string haslo)
         {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://warsztat-001-site1.etempurl.com/api/uzytkownik");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"login\": \"" + login + "\",\"haslo\": \"" + haslo + "\"}";
                streamWriter.Write(json);
                //string format
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}
