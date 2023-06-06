using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Depertment_1122
{
    class FireTruck
    {
        bool isChief;
        public FireTruck(bool isChief)
        {
            this.isChief = isChief;
        Ladder lad=new Ladder(23f,"Blue");      
        }
        public void setHosepie()
        {
            new Hosepipe("rubber","round",23.9f,23f);
        }
        public void setEmployee()
        {
            if(isChief==true)
            {
                new FireChief("Buta");
            }
            else
            {
                new FireFighter("Asghar");
            }
            new Employee("Ali");
        }
    }
}
