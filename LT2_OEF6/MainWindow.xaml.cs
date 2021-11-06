using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace LT2_OEF6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();//maakt timer aan
        int counter = 0;// maakt int aan

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);//stelt timer in

            timer.Tick += timer_Tick;
            timer.Start();//start timer
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            if (counter >= 10)
            {

                timer.Stop();//stopt timer
                counter = 0;
                timer.Start();//start timer

            }
            SolidColorBrush gray = new SolidColorBrush(Color.FromArgb(255, 128, 128, 128));//maakt kleuren grijs en rood aan
            SolidColorBrush red = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                Display display = new Display();//roept de class op
            bool[] segment = display.Lijn(counter);//maakt een array van alle nodige rode blokken
            lijnA.Fill = gray;
            lijnB.Fill = gray;
            lijnC.Fill = gray;//vult alles met grijs voor een reset
            lijnD.Fill = gray;
            lijnE.Fill = gray;
            lijnF.Fill = gray;
            lijnG.Fill = gray;

            //vult de nodige lijnen in met rood
            if (segment[0])
            {
                lijnA.Fill = red;
            }
            if (segment[1])
            {
                lijnB.Fill = red;
            }
            if (segment[2])
            {
                lijnC.Fill = red;
            }
            if (segment[3])
            {
                lijnD.Fill = red;
            }
            if (segment[4])
            {
                lijnE.Fill = red;
            }
            if (segment[5])
            {
                lijnF.Fill = red;
            }
            if (segment[6])
            {
                lijnG.Fill = red;
            }


            counter++;//telt op naar het volgend getal



        }


    }
}
