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

namespace WpfDemoFoto
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgPhoto.Source = new BitmapImage(new Uri("Images/20201019_073016.jpg", UriKind.Relative));
        }

        private void imgPhoto_MouseLeave(object sender, MouseEventArgs e)
        {
            imgPhoto.Opacity = 0.7;
        }

        private void imgPhoto_MouseEnter(object sender, MouseEventArgs e)
        {
            imgPhoto.Opacity = 1;
        }
    }
}
