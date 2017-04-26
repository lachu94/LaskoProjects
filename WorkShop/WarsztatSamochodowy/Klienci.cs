using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
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
    }
}
