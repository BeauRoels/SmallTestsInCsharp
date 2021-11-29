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

namespace WpfAlcohol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int aantalGlazenCara;
        int aantalGlazenWijn;
        int aantalGlazenWiskey;

        
        public void balkvergroten()
        {

        }

        private void sldCara_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aantalGlazenCara = (int)sldCara.Value;
            lblglazencara.Content = aantalGlazenCara.ToString();
            berekentotaal();
        }

        private void sldWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aantalGlazenWijn = (int)sldWijn.Value;
            lblglazenwijn.Content = aantalGlazenWijn.ToString();
            berekentotaal();
        }

        private void sldWiskey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aantalGlazenWiskey = (int)sldWiskey.Value;
            lblglazenwisky.Content = aantalGlazenWiskey.ToString();
            berekentotaal();
        }
        private void berekentotaal()
        {
            int totaalAantalglazen = aantalGlazenCara + aantalGlazenWijn + aantalGlazenWiskey;
            byte r = (byte)(17 * totaalAantalglazen);
            byte g = (byte)(255 - (17 * totaalAantalglazen));
            rectAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb(r, g, 0));
            rectAlcoholGehalte.Width = totaalAantalglazen * 50;
        }

    }
}
