using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT2_OEF5
{
    class QuizLid
    {
        public string[] Leden = new string[4];//slaat leden op en hun specialiteiten
        public string[] Specialiteit = new string[4];

        public QuizLid()
        {

        }
        public string label()
        {
            string label = $" {Leden[0]} {Specialiteit[0]} \n {Leden[1]} {Specialiteit[1]} \n {Leden[2]} {Specialiteit[2]} \n {Leden[3]} {Specialiteit[3]}";//maakt een string aan met new lines ertussen
            return label;
        }

    }
}
