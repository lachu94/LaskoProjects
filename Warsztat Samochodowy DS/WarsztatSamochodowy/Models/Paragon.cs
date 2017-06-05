using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy.Models
{
    public class Paragon
    {
        public int id { get; set; }
        public string nazwaProduktu { get; set; }

        public double cena { get; set; }
        public int ilosc { get; set; }
        public string razem { get { return string.Format("{0:0.00} PLN", cena * ilosc); } }

    }
}
