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

namespace WpfPriemgetal
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

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            int getal = Int32.Parse(txtGetal.Text);
            int tussenGetal = 0;
            
            tussenGetal = getal / 2;

            for (int i = 2; i <= tussenGetal; i++)
            {

                if(getal % i == 0)
                {
                    lblTextControleer.Foreground = new SolidColorBrush(Colors.Red);
                    lblTextControleer.Content = $"{getal} is geen priemgetal";
                }
                else
                {
                    lblTextControleer.Foreground = new SolidColorBrush(Colors.Green);
                    lblTextControleer.Content = $"{getal} is een priemgetal";
                }
            }
            
        }
    }
}
