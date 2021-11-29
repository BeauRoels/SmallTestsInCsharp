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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
            getal = rnd.Next(1, 10);
        }
        int poging = 0;
        Random rnd = new Random();
        int getal;

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
          
            
            int gok = Int32.Parse(txtGok.Text);
         
            poging++;
            int pogingover = 5-poging;


            if(gok < getal)
            {
                
                lbltip.Content = $"te laag! nog {pogingover} pogingen over" ;
            }
            else if(gok > getal)
            {
                lbltip.Content = $"te hoog! nog {pogingover} pogingen over";
            }
            else
            {
                lbltip.Content = "je hebt goed geraden!";
            }
        }
    }
}
