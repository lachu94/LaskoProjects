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
   public partial class Uzytkownicy
    {
        public int id_Uzytkownika { get; set; }
        public string Login { get; set; }
        public string Haslo {get;set;}
        public string Typ { get; set; }
        override public string ToString()
        {
            return String.Format( "{0}, {1}, {2}, {3}" , id_Uzytkownika, Login, Haslo,Typ ) ;
        }
        
    }
}
