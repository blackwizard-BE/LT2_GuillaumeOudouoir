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

namespace LT2_OEF1
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

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            try//voert data in de class leegt de lsb en voegt dan de data toe die aangevraagd werd via de class
            {
                Leerling leerling = new Leerling(txbNaam.Text, txbVoornaam.Text, txbKlas.Text);
                lsbResultaat.Items.Clear();
                lsbResultaat.Items.Add(leerling.getDataLeerling());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//sluit het programma
        }
    }
}
