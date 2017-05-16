using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy.Class
{
 public partial class Pracownik
    {
        public int id_Pracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int id_Uzytkownika { get; set; }
        string nrTelefonu { get; set; }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", id_Pracownika, Imie, Nazwisko, id_Uzytkownika, nrTelefonu);
        }

    }
}
