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

namespace WpfGebruikersnaam
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

        private void txtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            //reguliere expressie die kijkt naar het gebruik van speciale tekens, en laat enkel het alfabet toe

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNaam.Text, @"^[a-zA-Z]+$"))
                {
                    txtNaam.Background = Brushes.Red;
                }
            
        }
    }
}
