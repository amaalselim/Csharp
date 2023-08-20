using Microsoft.VisualBasic;

namespace strings
{
    internal class stringformatting
    {
        static void Main(string[] args)
        {
            double salary = 1000;
            string s = "Your Salary is : {0:c2}";// print $1000.00
            string s = "Your Salary is : {0:c5}";// print $1000.00000
            string s = "Your Salary is : {0:n2}";// print 1000.00
            string s = "Your Salary is : {0:0.00000}";// print 1000.00000
            s = string.Format(s, salary);
            Console.WriteLine(s);
        }

    }
}
