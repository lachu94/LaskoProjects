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
    public partial class Pracownicy
    {
        public int id_Pracownika { get; set; }
        [JsonProperty("Imie")]
        public string ImiePracownika { get; set; }

        [JsonProperty("Nazwisko")]
        public string NazwiskoPracownika { get; set; }
        public int id_Uzytkownika { get; set; }
        public string nrTelefonu { get; set; }
       
    }
}
