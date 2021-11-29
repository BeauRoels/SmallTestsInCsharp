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

namespace WpfRadioButton
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

        private void rbOptie1_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 1";
        }

        private void rbOptie2_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 2";
        }

        private void rbOptie3_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 3";
        }

        private void rbOptieA_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie a";

        }

        private void rbOptieB_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie b";
        }

        private void rbOptieC_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie c";
        }
        //unchecked
        private void rbOptie1_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbOptie2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbOptie3_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbOptieA_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbOptieB_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbOptieC_Unchecked(object sender, RoutedEventArgs e)
        {

        }

    }
}
