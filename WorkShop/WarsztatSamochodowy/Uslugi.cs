using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
{
    public partial class Uslugi
    {
        public int id_Uslugi { get; set; }
        public string Opis_Usterek { get; set; }
        public int id_Samochodu { get; set; }
        public int id_Pracownika { get; set; }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", id_Uslugi, Opis_Usterek, id_Samochodu, id_Pracownika);
        }
    }
}
