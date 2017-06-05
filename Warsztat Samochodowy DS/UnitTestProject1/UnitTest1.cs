using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarsztatSamochodowy.Komunikacja;
using WarsztatSamochodowy.Models;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Polaczenie pol = new Polaczenie();
       
      
        [TestMethod]
       public void GetRESTPracownik()
        {
            List<Pracownicy> result = pol.GetRESTPRacownik("http://warsztat-001-site1.etempurl.com/api/pracownik");
            result.ShouldBeEquivalentTo(new List<Pracownicy> { new Pracownicy { id_Pracownika = 1, ImiePracownika = "Patryk", NazwiskoPracownika = "Lasko", id_Uzytkownika = 1, nrTelefonu = "669578132" },

            new Pracownicy { id_Pracownika = 2, ImiePracownika = "Rafał", NazwiskoPracownika = "Góral", id_Uzytkownika = 5, nrTelefonu = "456328795" },
            new Pracownicy { id_Pracownika = 5, ImiePracownika = "Damian", NazwiskoPracownika = "Sielski", id_Uzytkownika = 6, nrTelefonu = "656456432" },
            new Pracownicy { id_Pracownika = 7, ImiePracownika = "Nieprzypisany", NazwiskoPracownika = "Nieprzypisany", id_Uzytkownika = 15, nrTelefonu = "Nieprzypisany" },
            new Pracownicy { id_Pracownika = 18, ImiePracownika = "Daniel", NazwiskoPracownika = "Zwierzynski", id_Uzytkownika = 12, nrTelefonu = "666123478" },
            new Pracownicy { id_Pracownika = 19, ImiePracownika = "Adam", NazwiskoPracownika = "Wąski", id_Uzytkownika = 13, nrTelefonu = "123456789" },
            new Pracownicy { id_Pracownika = 20, ImiePracownika = "Adam", NazwiskoPracownika = "Wąski", id_Uzytkownika = 14, nrTelefonu = "123456789" },
            new Pracownicy { id_Pracownika = 21, ImiePracownika = "Adam", NazwiskoPracownika = "Dobr", id_Uzytkownika = 16, nrTelefonu = "123456789" },});

        }
    }
}
