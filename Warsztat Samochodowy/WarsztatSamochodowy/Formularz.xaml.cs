using System.Windows;
using WarsztatSamochodowy.Models;
namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for Formularz.xaml
    /// </summary>
    public partial class Formularz : Window
    {
        Klienci klient = new Klienci();
        Samochody samochod = new Samochody();
        Uslugi usluga = new Uslugi();
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
                        klient.PostRESTKlienci("http://warsztat-001-site1.etempurl.com/api/klient", new Klienci() { Imie = imie, Nazwisko = nazwisko, Telefon = telefon });
                    }
                }
            }

            string model = txtModel.Text;
            string marka = txtMarka.Text;
            string typSilnika = cboxTypSilnika.Text;

            if (model.Length > 0)
            {
                if (marka.Length > 0)
                {
                    if (typSilnika.Length > 0)
                    {
                        samochod.PostRESTSamochody("http://warsztat-001-site1.etempurl.com/api/samochod/4", new Samochody() { Marka = marka, Model = model, Typ_silnika = typSilnika });
                    }
                }
            }

            string opisUsterki = txtOpisUsterki.Text;
            if (opisUsterki.Length > 0)
            {
                usluga.PostRESTUslugi("http://warsztat-001-site1.etempurl.com/api/usluga", new Uslugi() { Opis_Usterek = opisUsterki });
            }


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            
           
            mm.Show();
            this.Close();
        }
    }
}
