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

namespace WpfBieden
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
        // string[] namen;
        // int[] boden;
        // int x = 0, y = 0;
        String vorigenaam = "";
        int vorigbod = 0;

        private void btnplaatsbod_Click(object sender, RoutedEventArgs e)
        {

            // x++;
            // y++;


            //  namen[x] = naam;
            // boden[x] = bod;

            // for (int i = 0; i < boden.Length; i++)
            // {
            //  if (boden[i] < boden[i + 1])
            // {
            // lblhoogstebod.Content = $"{namen[i]} heeft een grote bod met {boden[i]}";
            // }
            // }
            // String invoer ;
           
          
            int bod = Int32.Parse(txtbod.Text);
            string naam = txtnaam.Text;
            if (bod < vorigbod)
            {
                lblhoogstebod.Content = $"{vorigenaam} heeft een grote bod met {vorigbod}";
            }
            vorigbod = bod;
            vorigenaam = naam;








        }
    }
    }
