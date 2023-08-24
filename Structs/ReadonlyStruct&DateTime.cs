using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troubleshooting
{
    internal class ReadonlyStructs
    {
        static void Main(string[] args)
        {
            DateTime dt; // DateTime is Struct (value type);
            dt = DateTime.Now;
            Console.WriteLine(dt);
            dt.AddDays(10); // immutable but when I say : 
            Console.WriteLine($"immutable: {dt}");
            dt = dt.AddDays(10); // saved data in dt (changed) so can be mutable;
            Console.WriteLine($"mutable: {dt}");
            DateTime dt1 = new DateTime(2023, 08, 24);
            Console.WriteLine(dt1);
            DateTime dt2 = new DateTime(2023, 08, 24, 03, 05, 00);
            Console.WriteLine(dt2);

        }

    }
    readonly struct Age // When make struck readonly , All of members in struct must be readonly
    {
        readonly public int Years;
        readonly public int whatever;
        public Age(int years, int whatever)
        {
            this.Years = years;
            this.whatever = whatever;
        }

    }

}
