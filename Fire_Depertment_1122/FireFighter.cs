using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Depertment_1122
{
    class FireFighter:Employee
    {
        public FireFighter(string name):base(name)
        {
           
        }
        public void Extinguish()
        {
            Console.Write("Pishhhhhhhhhhhhhhhhhhhhhhhhhh");
        }
        public void Drive()
        {
            Console.Write("Ratattatatatatatatatatatatataata");
        }

    }
}
