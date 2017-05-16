using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
{
   public partial class Uzytkownik
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
