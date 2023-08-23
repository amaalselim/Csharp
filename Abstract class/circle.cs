using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class circle :shape
    {
        public double radius { get; set; }
        public override double calculatedarea()
        {
            return Math.PI * radius * radius;
        }

    }
}
