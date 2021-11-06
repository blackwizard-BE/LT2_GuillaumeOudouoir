using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace LT2_OEF4
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random r = new Random();//creeert een random gradient brush en fillt de ellipse ermee 
                RadialGradientBrush myRadialGradientBrush = new RadialGradientBrush();
                myRadialGradientBrush.GradientOrigin = new Point(0.5, 0.5);
                myRadialGradientBrush.Center = new Point(0.5, 0.5);
                myRadialGradientBrush.RadiusX = 0.5;
                myRadialGradientBrush.RadiusY = 0.5;
                myRadialGradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb((byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256)), 0.0));
                myRadialGradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb((byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256)), 1.0));
                elsCD.Fill = myRadialGradientBrush;
                CD cd = new CD(txbTitel.Text, txbUitvoerder.Text, Convert.ToInt32(txbAantalLiedjes.Text));//geeft data door aan de class en vraagt dan de data terug op en voegt deze toe aan de corresponderende label
                lblCDTitel.Content = cd.Titel;
                lblCDUitvoerder.Content = cd.Uitvoerder;
                lblCDAantal.Content = $"{cd.Aantal} Tracks";
            } catch (Exception ex) { MessageBox.Show("Je hebt verkeerde waarden ingevuld."); }
        }

    }
}
