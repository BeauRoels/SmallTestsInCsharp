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

namespace WpfPizzatime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    { 
        BitmapImage pizzahot = new BitmapImage(new Uri("Images/hot.jpg", (UriKind.Relative)));
        BitmapImage pizzahawaii = new BitmapImage(new Uri("Images/hawaii.jpg", (UriKind.Relative)));
        BitmapImage pizza4s = new BitmapImage(new Uri("Images/4s.jpg", (UriKind.Relative)));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbHot_Checked(object sender, RoutedEventArgs e)
        {
            imgpizza.Source = pizzahot;
            lblpizzakeuze.Content = rbHot.Content;


        }

        private void rb4seasons_Checked(object sender, RoutedEventArgs e)
        {
            imgpizza.Source = pizzahawaii;
            lblpizzakeuze.Content = rb4seasons.Content;

        }

        private void rbhawaii_Checked(object sender, RoutedEventArgs e)
        {
            imgpizza.Source = pizza4s;
            lblpizzakeuze.Content = rbhawaii.Content;

        }
    }
}
