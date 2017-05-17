using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WarsztatSamochodowy;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://warsztat-001-site1.etempurl.com/api/uzytkownik";
        [TestMethod]
        public void TestMethod1()
        {
           
            Mock<MainWindow> mock = new Mock<MainWindow>();
            mock.Setup(m=>m.GetRESTUzytkownik(url)).Returns(new List<Uzytkownik>{ new Uzytkownik() {Login="Admin",Typ="Szef" } });

            MainWindow sc = new MainWindow(mock.Object);
            var u = (List<Uzytkownik>)sc.GetRESTUzytkownik().Model;
            Assert.AreEqual(1, u.Count, "Zły login i typ");


        }
    }
}
