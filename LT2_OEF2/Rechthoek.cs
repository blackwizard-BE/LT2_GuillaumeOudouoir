using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT2_OEF2
{
    class Rechthoek
    {
        private double hoogte;//maakt variabelen aan
        private double basis;

        public double oppervlakte()//berkent de oppervlakte rond deze af en returnt deze
        {
            double oppervlakte = hoogte * basis;
            return Math.Round(oppervlakte, 2);
        }
        public Rechthoek(double Hoogte, double Basis)//maakt gelijk 
        {
            hoogte = Hoogte;
            basis = Basis;
        }
    }
}
