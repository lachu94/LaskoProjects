
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
            btnFormularz.Visibility = System.Windows.Visibility.Hidden;
            btnZlecenia.Visibility = System.Windows.Visibility.Hidden;
            stan = MainWindow.pUprawnienia;
            if (stan == "admin") { btnZlecenia.Visibility = System.Windows.Visibility.Visible; }
            else { btnFormularz.Visibility = System.Windows.Visibility.Visible; }
        }

        private void btnZlecenia_Click(object sender, RoutedEventArgs e)
        {
            Zlecenia zl = new Zlecenia();
            zl.Show();
            Close();
        }
        private void btnFormularz_Click(object sender, RoutedEventArgs e)
        {
            Formularz fm = new Formularz();
            fm.Show();
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
    }
}
