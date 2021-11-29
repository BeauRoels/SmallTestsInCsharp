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

namespace WpfFormChecking
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

        private void btnregistreren_Click(object sender, RoutedEventArgs e)
        {
            if(txtnaam.Text == null)
            {
                lblnaam.Content = "moet ingevuld zijn";
            }
            else if (txtmail.Text == null)
            {
                lblmail.Content = "moet ingevuld zijn";
            }
            else if (dateDatum.SelectedDate == null)
            {
                lbldatum.Content = "moet ingevuld zijn";
            }
            else if (cbprofiel.SelectedItem == null)
            {
                lblprof.Content = "moet ingevuld zijn";
            }
            else if (pswpasswoord.Password == null)
            {
                lblpass.Content = "moet ingevuld zijn";
            }
            else if (rbman.IsChecked == false && rbvrouw.IsChecked == false)
            {
                lblsex.Content = "moet ingevuld zijn";
            }
            else if (cbnetwerken.IsChecked == false && cbbusiness.IsChecked==false && cbprogrameren.IsChecked==false)
            {
                lblint.Content = "moet ingevuld zijn";
            }
        }

        private void btnwissen_Click(object sender, RoutedEventArgs e)
        {
            txtnaam.Text = null;
            txtmail.Text = null;
            dateDatum.SelectedDate =null;
            pswpasswoord.Password = null;
            rbman.IsChecked = false;
            rbvrouw.IsChecked =false;
            cbnetwerken.IsChecked = false;
            cbbusiness.IsChecked = false;
            cbprogrameren.IsChecked = false;
        }
    }
}
