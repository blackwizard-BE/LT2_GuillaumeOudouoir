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

namespace LT2_OEF2
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)//stuurt door naar de class en roept de oppervlakte op
        {
            Rechthoek rechthoek= new Rechthoek(Convert.ToDouble(txbHoogte.Text), Convert.ToDouble(txbBasis.Text));
            lblResultaat.Content = rechthoek.oppervlakte().ToString();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {//sluit af
            Close();
        }
    }
}
