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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace WpfApplication19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Osoba osoba1;
        public MainWindow()
        {
            InitializeComponent();
            osoba1 = new Osoba();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime dataP = DateTime.ParseExact(DataUrodzenia.Text,"dd.MM.yyyy",CultureInfo.InvariantCulture);
                osoba1.Ustaw(Imie.Text, Nazwisko.Text, dataP);
                Opis.Text=osoba1.ToString();
            }
            catch
            {
                MessageBox.Show("coś nie tak");
            }
        }
    }
}
