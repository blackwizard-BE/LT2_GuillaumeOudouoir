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

namespace LT2_OEF5
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
        int i = 0;//maakt int aan en roept de class op
        QuizLid quizLid = new QuizLid();
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            if (i < 4)//kijkt naar het aantal ingaven als er meer dan 4 zijn dan stopt hij en displayt hij het in de label
            {
                quizLid.Leden[i] = txbNaam.Text;
                quizLid.Specialiteit[i] = txbSpecialiteit.Text;
                Console.WriteLine("blublub");
            }
            if(i == 3)
            {
                lblRes.Content = quizLid.label();
            }
            i++;
            txbNaam.Clear();
            txbSpecialiteit.Clear();
            int ii = i + 1;
            if (ii == 5)
            {
                ii--;
            }
            lblQuizLid.Content = $"Naam van QuizLid {ii}:";


        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnNext.Visibility = Visibility.Visible;
            lblQuizLid.Visibility = Visibility.Visible;//zet alles visible ging het eerst anders doen maar heb het dan vergeten te verwijderen en ik vind het passender als er een start knop bij zit
            lblSpecialiteit.Visibility = Visibility.Visible;
            txbSpecialiteit.Visibility = Visibility.Visible;
            txbNaam.Visibility = Visibility.Visible;
            btnStart.Visibility = Visibility.Hidden;



        }
    }
}
