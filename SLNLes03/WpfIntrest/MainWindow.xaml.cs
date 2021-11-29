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

namespace WpfIntrest
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

        private void btnberekenen_Click(object sender, RoutedEventArgs e)
        {
            double startbedrag = Double.Parse(txtBedrag.Text);
            double inrest = Double.Parse(txtintrest.Text)/100;

            double periode = sldperiode.Value;
            
            double berekening = startbedrag * Math.Pow( (1 + inrest), periode);
            double berekeningAfgerond = Math.Round(berekening, 2);
            lbltotaal.Content = "De waarde na " + periode + " jaar bedraagt € " + berekeningAfgerond;
        }

        private void sldperiode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double periode = sldperiode.Value;
            lbljaar.Content = periode.ToString();
        }
    }
}
