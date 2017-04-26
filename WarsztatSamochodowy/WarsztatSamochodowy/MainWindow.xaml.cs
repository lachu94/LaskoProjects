using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WarsztatSamochodowy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
         
        private List<Uzytkownik>   GetRESTUzytkownik(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Uzytkownik>>(s);

        }
       








        public MainWindow()
        {
           
            InitializeComponent();
           
        }
       
        public static bool l;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Uzytkownik> uzytkownik = GetRESTUzytkownik("http://warsztat-001-site1.etempurl.com/api/uzytkownik");

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
                    if(typ == "admin")
                    {
                        Dodaj dodaj = new Dodaj();
                        dodaj.Show();

                        

                        Close();
                    }
                    else if (typ == "user")
                    {   
                        Wyswietl wyswietl = new Wyswietl();

                        wyswietl.Show();
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
 

      

       
    }
}
