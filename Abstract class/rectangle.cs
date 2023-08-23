using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class rectangle : shape
    {
        public  double length { get; set; }
        public double width { get; set; }
        public override double calculatedarea()
        {
            return length * width;
        }
        
    }
}
