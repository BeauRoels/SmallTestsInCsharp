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

namespace WpfSliderKleur
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

        private void sldKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblkleur.Content = sldKleur.Value;
            byte r = (byte)(sldKleur.Value*2);
            byte g = (byte)(255-(sldKleur.Value*2) );
            byte b = 0;
           
          
         
            lblkleur.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}
