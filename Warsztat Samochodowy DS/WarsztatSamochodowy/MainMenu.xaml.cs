using System.Diagnostics;
using System.Windows;


namespace WarsztatSamochodowy
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public static string stan="";
        public MainMenu()
        {
            
            InitializeComponent();
            stan = MainWindow.pUprawnienia;
            btnDodajP.Visibility = Visibility.Hidden;
            btnZlecenia.Visibility = System.Windows.Visibility.Hidden;
            
            if (stan == "Szef") { btnZlecenia.Visibility = System.Windows.Visibility.Visible; }
            if (stan == "Szef") { btnDodajP.Visibility = System.Windows.Visibility.Visible; }

        }

        private void btnZlecenia_Click(object sender, RoutedEventArgs e)
        {
            ZobaczZlecenia zl = new ZobaczZlecenia();
            zl.Show();
            Close();
        }
     

        private void btnWyloguj_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
          
            mw.Show();
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
            Close();
            
        }

        private void btnFormularz_Click_1(object sender, RoutedEventArgs e)
        {
            Formularz fm = new Formularz();
            fm.Show();
            Close();
        }

        private void btnWyjscie_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDodajP_Click(object sender, RoutedEventArgs e)
        {
            DodajPracownika dp = new DodajPracownika();
            dp.Show();
            Close();
        }

        private void btnMinimalizuj_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
