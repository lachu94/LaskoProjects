using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WarsztatSamochodowy.Models;
using WarsztatSamochodowy.Komunikacja;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for DodajPracownika.xaml
    /// </summary>
    public partial class DodajPracownika : Window
    {
        int idp = 0;
        int idu = 0;
        Pracownicy p = new Pracownicy();
        Uzytkownicy u = new Uzytkownicy();
        Polaczenie pol = new Polaczenie();
        public DodajPracownika()
        {
            InitializeComponent();
        }

        private void btnDodajPracownika_Click(object sender, RoutedEventArgs e)
        {



            //Uzytkownik

            string login = txtLogin.Text;
            string haslo = pasHaslo.Password;
            string typKonta = comboBox.Text;


            if (login.Length > 0)
            {
                if (haslo.Length > 0)
                {
                    if (typKonta.Length > 0)
                    {
                        idu = pol.PostRESTUzytkownicy("http://warsztat-001-site1.etempurl.com/api/uzytkownik", new Uzytkownicy() { Login = login, Haslo = haslo, Typ = typKonta });

                    }
                }
            }




            //Pracownik
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string telefon = txtTelefon.Text;

            if (imie.Length > 0)
            {
                if (nazwisko.Length > 0)
                {
                    if (telefon.Length > 0)
                    {
                       pol.PostRESTPracownicy("http://warsztat-001-site1.etempurl.com/api/pracownik", new Pracownicy() { ImiePracownika = imie, NazwiskoPracownika = nazwisko, id_Uzytkownika = idu, nrTelefonu = telefon });

                    }
                }
            }
            DodajPracownika dp = new DodajPracownika();
            dp.Show();
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
