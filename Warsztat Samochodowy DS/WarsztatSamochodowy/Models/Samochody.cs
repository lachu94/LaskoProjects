using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

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
       
    }
}
