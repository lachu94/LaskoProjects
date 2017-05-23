using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows;
using WarsztatSamochodowy.Models;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for Formularz.xaml
    /// </summary>
    public partial class Formularz : Window
    {
   
        int idk = 0;
        int ids = 0;
        int idu = 0;
        Klienci k = new Klienci();
        Samochody s = new Samochody();
        Uslugi u = new Uslugi();



        public Formularz()
        {
            InitializeComponent();
          
        }
        private void btnZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string telefon = txtTelefon.Text;
           
            if (imie.Length > 0)
            {
                if (nazwisko.Length > 0)
                {
                    if (telefon.Length > 0)
                    {
                   idk= k.PostRESTKlienci("http://warsztat-001-site1.etempurl.com/api/klient", new Klienci() { Imie = imie, Nazwisko = nazwisko, Telefon = telefon });
          
                    }
                }
            }     
            string model = txtModel.Text;
            string marka = txtMarka.Text;
            string typSilnika = cboxTypSilnika.Text;
            //Samochód 
            if (model.Length > 0)
            {
                if (marka.Length > 0)
                {
                    if (typSilnika.Length > 0)
                    {
                        ids = s.PostRESTSamochody("http://warsztat-001-site1.etempurl.com/api/samochod/", new Samochody() { Marka = marka, Model = model, Typ_silnika = typSilnika, id_Klienta = idk });
                    }
                }
            }
         
                    //Usluga
                    string opisUsterki = txtOpisUsterki.Text;
                    if (opisUsterki.Length > 0)
                    {
                        u.PostRESTUslugi("http://warsztat-001-site1.etempurl.com/api/usluga/", new Uslugi() { Opis_Usterek = opisUsterki, id_Samochodu = ids, id_Pracownika = 7, Status = "Przyjęte", Podsumowanie = "Brak", Cena = 0});
                    }
            Formularz fm = new Formularz();


            fm.Show();
            this.Close();

        }
            

       
             

   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu();


            mm.Show();
            this.Close();
        }
    }
}
