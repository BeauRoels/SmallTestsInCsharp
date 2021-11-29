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

namespace WpfIngredientenVervolg
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

        private void btnMaakLijst_Click(object sender, RoutedEventArgs e)
        {
            int aantalPersonen = Int32.Parse(cbpersoon.Text);

            int hoeveelheidEen, hoeveelheidTwee, hoeveelheidDrie, hoeveelheidVier;
            int totaalEen, totaalTwee, totaalDrie, totaalVier;

            string eenheideen = cbeen.Text, eenheidtwee = cbtwee.Text, eenheiddrie = cbdrie.Text, eenheidvier = cbvier.Text;
          
            hoeveelheidEen = Int32.Parse(txtHoeveelheideerste.Text);
            hoeveelheidTwee = Int32.Parse(txtHoeveelheidtweede.Text);
            hoeveelheidDrie = Int32.Parse(txtHoeveelheidderde.Text);
            hoeveelheidVier = Int32.Parse(txtHoeveelheidvierde.Text);

            totaalEen = aantalPersonen * hoeveelheidEen;
            totaalTwee = aantalPersonen * hoeveelheidTwee;
            totaalDrie = aantalPersonen * hoeveelheidDrie;
            totaalVier = aantalPersonen * hoeveelheidVier;


            lbllijstvolledig.Content = $"-  {totaalEen} {eenheideen} {txtIngredienteerste.Text}\n" +
                                       $"-  {totaalTwee} {eenheidtwee} {txtIngredienttweede.Text}\n" +
                                       $"-  {totaalDrie} {eenheiddrie} {txtIngredientderde.Text}\n" +
                                       $"-  {totaalVier} {eenheidvier} {txtIngredientvierde.Text}\n";


        }
    }
}
