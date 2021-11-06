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

namespace LT_OEF3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Cirkel cirkel = new Cirkel(Convert.ToDouble(txbStraal.Text), cnvResultaat);//maakt circle aan door middel van de class
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)//maakt de circle an en berekent de oppervlakte en de omtrek via de class
        {

            Cirkel cirkel = new Cirkel(Convert.ToDouble(txbStraal.Text), cnvResultaat);
            lblOmtrek.Content = $"Omtrek: {cirkel.Omtrek(Convert.ToDouble(txbStraal.Text))}";
            lblOppervlakte.Content = $"Oppervlakte: {cirkel.Oppervlakte(Convert.ToDouble(txbStraal.Text))}";
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();//sluit het programma af
        }
    }
}
