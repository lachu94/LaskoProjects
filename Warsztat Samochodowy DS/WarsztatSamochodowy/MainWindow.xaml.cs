using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using WarsztatSamochodowy.Models;
using WarsztatSamochodowy.Komunikacja;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        public static string pUprawnienia = "";
        Uzytkownicy user = new Uzytkownicy();
        public static bool l;
        Polaczenie pol = new Polaczenie();
     

        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Uzytkownicy> uzytkownik = pol.GetRESTUzytkownik("http://warsztat-001-site1.etempurl.com/api/uzytkownik");
                  string typ = "";
            int id = 0;
            int length = uzytkownik.Count;
                    
            foreach (var r in uzytkownik)
            {
                // if (r.Login.Equals(txtLogin.Text) && r.Haslo.Equals(txtHaslo.Text))
                if (String.Compare(txtLogin.Text, r.Login, false) == 0 && String.Compare(passwordBox.Password, r.Haslo, false) == 0)
                {
                    id = r.id_Uzytkownika;
                    typ = r.Typ;

                    if(typ == "Szef")
                    {
                        pUprawnienia = typ;
                        MainMenu mm = new MainMenu();
                        
                        mm.Show();      
                        Close();
                    }
                    else if (typ == "Pracownik")
                    {   
                        MainMenu mm = new MainMenu();
                        pUprawnienia = typ;
                     
                        mm.Show();
                        Close();
                    }                                    
                    MessageBox.Show("Zalogowałeś się jako " + typ);
                    l = true;
                    // Przechodzenie do kolejnego okna
                    break;
                }
            }
            if (l == false) MessageBox.Show("Błędny login lub hasło");                      
        }

        private void btnZamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimalizuj_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
