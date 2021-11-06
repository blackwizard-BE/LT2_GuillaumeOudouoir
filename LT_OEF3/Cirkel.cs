using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LT_OEF3
{
    class Cirkel
    {
        public Cirkel(double straal, Canvas aCanvas)
        {
            Ellipse newEllipse = new Ellipse();//creeerd een ellipse via de straal geeft hem een kleur en voegt hem toe aan het canvas
            newEllipse.Width = straal*2;
            newEllipse.Height = straal*2;
            newEllipse.Fill = new SolidColorBrush(Colors.Gray);
            aCanvas.Children.Clear();
            aCanvas.Children.Add(newEllipse);
            Canvas.SetLeft(newEllipse, 200 / 2.0- straal);
            Canvas.SetTop(newEllipse,200 / 2.0-straal); 

        }
        public double Omtrek(double straal)//berekent de omtrek
        {
            double Omtrek = 2*straal*Math.PI;
            return Math.Round(Omtrek,2);
        }
        public double Oppervlakte(double straal)//berekent de oppervlakte
        {
            double Oppervlakte = straal*straal * Math.PI;
            return Math.Round(Oppervlakte, 2);
        }



    }
}
