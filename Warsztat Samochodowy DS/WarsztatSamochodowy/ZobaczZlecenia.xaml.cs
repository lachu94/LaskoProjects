using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WarsztatSamochodowy.Komunikacja;
using WarsztatSamochodowy.Models;

namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for ZobaczZlecenia.xaml
    /// </summary>

    public partial class ZobaczZlecenia : Window
    {
      
        Klienci klient = new Klienci();
        Samochody samochod = new Samochody();
        Uslugi usluga = new Uslugi();
        Pracownicy pracownik = new Pracownicy();
        Polaczenie pol = new Polaczenie();
    
        public ZobaczZlecenia()
        {
            InitializeComponent();
           
            btnParagon.Visibility = Visibility.Hidden;
            btnOk.Visibility = Visibility.Hidden;
            List<Klienci> klienci = pol.GetRESTKlient("http://warsztat-001-site1.etempurl.com/api/klient");
            int firstidK = klienci.Min(k => k.id_Klienta);
            int lastidK = klienci.Max(k => k.id_Klienta);
            
            List<Samochody> samochody = new List<Samochody>();
            List<Uslugi> uslugi = new List<Uslugi>();
            List<Pracownicy> pracownicy = pol.GetRESTPRacownik("http://warsztat-001-site1.etempurl.com/api/pracownik");

            for (int i = firstidK; i <= lastidK; i++)
            {
                samochody.AddRange(pol.GetRESTSamochod("http://warsztat-001-site1.etempurl.com/api/samochod/" + i));
            }
            int fistidS = samochody.Min(s => s.id_Samochodu);
            int lastidS = samochody.Max(s => s.id_Samochodu);
            try
            {
                for (int i = fistidS; i <= lastidS; i++)
                {
                    uslugi.AddRange(pol.GetRESTUsluga("http://warsztat-001-site1.etempurl.com/api/usluga/" + i));
                }
            }
            catch { }
     
         
            var memberRealEstateList =
     (from k in klienci
      from s in samochody
      from u in uslugi
      from p in pracownicy
      where k.id_Klienta == s.id_Klienta && s.id_Samochodu == u.id_Samochodu && u.id_Pracownika==p.id_Pracownika
      select new OrderMerged()
      {
          id_Klienta=k.id_Klienta,
          Imie = k.Imie,
          Nazwisko= k.Nazwisko,
          Telefon = k.Telefon,
          id_Samochodu=s.id_Samochodu,
          Marka=s.Marka,
          Model = s.Model,
          Typ_silnika=s.Typ_silnika,
          id_Uslugi= u.id_Uslugi,
          Opis_Usterek= u.Opis_Usterek,
          Status = u.Status,
          Podsumowanie = u.Podsumowanie,
          Cena= u.Cena,
          id_Pracownika=p.id_Pracownika,
          ImiePracownika=p.ImiePracownika,
          NazwiskoPracownika=p.NazwiskoPracownika,
          nrTelefonu=p.nrTelefonu
          

          
      }).ToList();
            List<string> listStatus = new List<string>();
            listStatus.Add("Przyjęte");
            listStatus.Add("W realizacji");
            listStatus.Add("Zrealizowane");
            listStatus.Add("Zapłacone");
            List<string> listPracownicy = new List<string>();
                foreach (var item in pracownicy)
                {
                    listPracownicy.Add(item.NazwiskoPracownika);
                }
            cbStatus.ItemsSource = listStatus;
            cbWorkers.ItemsSource = listPracownicy;
            dgOrders.ItemsSource = memberRealEstateList;
        
        
        }
   
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Close();
            mm.Show();
        }
        [STAThread]
        private void btnParagon_Click(object sender, RoutedEventArgs e)
        {
            OrderMerged m = dgOrders.SelectedItem as OrderMerged;
            string idU= m.id_Uslugi.ToString();
            string Status = m.Status;
            string Opis = m.Opis_Usterek;
            string idP = m.id_Pracownika.ToString();
            string idS = m.id_Samochodu.ToString();
            System.Windows.MessageBox.Show(idU + Status + Opis + idP + idS);

            DaneParagonu paragon = new DaneParagonu();
            MainMenu mm = new MainMenu();
            mm.Show();
            paragon.Show();
        }
        private void StatusSelectionChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            try
            {
                if (comboBox.SelectedItem.ToString() == "Zapłacone")
                {


                    btnParagon.Visibility = Visibility.Visible;
                    btnOk.Visibility = Visibility.Visible;

                }
            } catch
            {

            }
         
        }
        private void WorkerSelectionChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
         
  
            try
            {


                //if ( comboBox.Contnent.ToString()  != comboBox.SelectedItem.ToString())
                //{


                  
                //    btnOk.Visibility = Visibility.Visible;

                //}


            }
            catch
            {

            }

        }

      

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class OrderMerged
    {
        public int id_Klienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public int id_Samochodu { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Typ_silnika { get; set; }
        public int id_Uslugi { get; set; }
        public string Opis_Usterek { get; set; }
        public string Status { get; set; }
        public string Podsumowanie { get; set; }
        public double Cena { get; set; }
        public int id_Pracownika { get; set; }
        public string ImiePracownika { get; set; }
        public string NazwiskoPracownika { get; set; }
        public string nrTelefonu { get; set; }
    }


}
