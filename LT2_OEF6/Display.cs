using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT2_OEF6
{
    class Display
    {
        
        public Display()
        {

        }
        public bool[] Lijn(int getal)//"decodeert" het getal en zet het om naar 7 segmenten voor de display, het zet eerst alles naar true omdat er gemiddeld meer rode vakken zijn dan grijze en dan zet het alle grijze vakken gelijk aan false volgens het gegeven nummer
        {
            bool[] lijnen = new bool[7];
            lijnen[0] = true;
            lijnen[1] = true;
            lijnen[2] = true;
            lijnen[3] = true;
            lijnen[4] = true;
            lijnen[5] = true;
            lijnen[6] = true;

            if(getal == 0)
            {
                lijnen[6] = false;
            }
            if(getal == 1)
            {
                lijnen[0] = false;
                lijnen[3] = false;
                lijnen[4] = false;
                lijnen[5] = false;
                lijnen[6] = false;
            }
            if(getal == 2)
            {
                lijnen[2] = false;
                lijnen[5] = false;
            }
            if(getal == 3)
            {
                lijnen[4] = false;
                lijnen[5] = false;
            }
            if(getal == 4)
            {
                lijnen[0] = false;
                lijnen[3] = false;
                lijnen[4] = false;
            }
            if(getal == 5)
            {
                lijnen[1] = false;
                lijnen[4] = false;
            }
            if (getal == 6)
            {
                lijnen[1] = false;
            }
            if (getal == 7)
            {
                lijnen[3] = false;
                lijnen[4] = false;
                lijnen[5] = false;
                lijnen[6] = false;
            }
            if(getal == 9)
            {
                lijnen[4] = false;
            }
            return lijnen;

        }


    }
}
