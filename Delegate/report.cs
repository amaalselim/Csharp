using System;

namespace Delegate
{
    internal class report
    {
        public delegate bool delg(Employee s);
        public void processemployee(Employee[] employees , string title , delg del)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var e in employees)
            {
                if (del(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.Totalsales}");

                }

            }
            Console.WriteLine("\n\n");
        }
        
    }
}
