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

namespace WpfEllipsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int AANTAL_ELIPSEN;
            int MIN_RADIUS = 60, MAX_RADIUS = 150;
            InitializeComponent();
            // maak de ellips
            Ellipse newEllipse = new Ellipse();
            newEllipse.Width = 150;
            newEllipse.Height = 60;
            newEllipse.Fill = new SolidColorBrush(Color.FromRgb(122, 78, 200));
            double xPos = 50;
            double yPos = 85;
            newEllipse.SetValue(Canvas.LeftProperty, xPos);
            newEllipse.SetValue(Canvas.TopProperty, yPos);
            //voeg ellips toe aan het canvas
            canvas1.Children.Add(newEllipse);
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            

            Ellipse newnewEllipse = new Ellipse();
            newnewEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
            newnewEllipse.Width = rnd.Next(150);
            newnewEllipse.Height = rnd.Next(60);
            double xPos = rnd.Next(500);
            double yPos = rnd.Next(500);

            newnewEllipse.SetValue(Canvas.LeftProperty, xPos);
            newnewEllipse.SetValue(Canvas.TopProperty, yPos);
            canvas1.Children.Add(newnewEllipse);

        }
    }
}
