using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarsztatSamochodowy.Models;

namespace WarsztatSamochodowy.Komunikacja
{
   public interface IPolaczenie
    {
        //Klient
        List<Klienci> GetRESTKlient(string uri);
        int PostRESTKlienci(string uri, Klienci k);

        //Pracownicy
        List<Pracownicy> GetRESTPRacownik(string uri);
        int PostRESTPracownicy(string uri, Pracownicy s);

        //Samochody
        List<Samochody> GetRESTSamochod(string uri);
        int PostRESTSamochody(string uri, Samochody s);

        //Uslugi
        List<Uslugi> GetRESTUsluga(string uri);
        int PostRESTUslugi(string uri, Uslugi u);

        //Uzytkownicy
        List<Uzytkownicy> GetRESTUzytkownik(string uri);
        int PostRESTUzytkownicy(string uri, Uzytkownicy s);


    }
}
