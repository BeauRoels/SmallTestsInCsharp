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

namespace WpfIngrediënten
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
            int aantalPersonen;
            int hoeveelheidEen, hoeveelheidTwee, hoeveelheidDrie, hoeveelheidVier;
            int totaalEen, totaalTwee, totaalDrie, totaalVier;

            aantalPersonen = Int32.Parse(txtAPersonen.Text);
            hoeveelheidEen = Int32.Parse(txtHoeveelheideerste.Text);
            hoeveelheidTwee = Int32.Parse(txtHoeveelheidtweede.Text);
            hoeveelheidDrie = Int32.Parse(txtHoeveelheidderde.Text);
            hoeveelheidVier = Int32.Parse(txtHoeveelheidvierde.Text);

            totaalEen = aantalPersonen * hoeveelheidEen;
            totaalTwee = aantalPersonen * hoeveelheidTwee;
            totaalDrie = aantalPersonen * hoeveelheidDrie;
            totaalVier = aantalPersonen * hoeveelheidVier;

            lbleersteItem.Content = "- " + totaalEen + txtEenheideerste.Text + " " + txtIngredienteerste.Text;
            lbltweedeItem.Content = "- " + totaalTwee + txtEenheidtweede.Text + " " + txtIngredienttweede.Text;
            lblderdeItem.Content = "- " + totaalDrie + txtEenheidtderde.Text + " " + txtIngredientderde.Text;
            lblvierdeItem.Content = "- " + totaalVier + txtEenheidvierde.Text + " " + txtIngredientvierde.Text;

            //String interpolatie

            lbllijstvolledig.Content = $"-  {totaalEen} {txtEenheideerste.Text} {txtIngredienteerste.Text}\n" +
                                       $"-  {totaalTwee} {txtEenheidtweede.Text} {txtIngredienttweede.Text}\n" +
                                       $"-  {totaalDrie} {txtEenheidtderde.Text} {txtIngredientderde.Text}\n" +
                                       $"-  {totaalVier} {txtEenheidvierde.Text} {txtIngredientvierde.Text}\n";








        }
    }
}
