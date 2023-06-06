using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Depertment_1122
{
    class Hosepipe
    {
        public string model;
        public string shape;
        public float dia;
        public float flow_rate;
        public Hosepipe(string model,string shape, float dia, float flow_rate)
        {
            
            this.model = model;
            this.shape = shape;
            this.dia = dia;
            this.flow_rate = flow_rate;
        }
    }
}
