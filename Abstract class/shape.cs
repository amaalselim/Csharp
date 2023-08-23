using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal abstract class shape
    {
        public abstract double calculatedarea();
        public void printarea()
        {
            Console.WriteLine($"Area= {calculatedarea()}");
        }
    }
}
