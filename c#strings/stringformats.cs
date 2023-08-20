using Microsoft.VisualBasic;

namespace strings
{
    internal class stringformatting
    {
        static void Main(string[] args)
        {
            string str = "Hello {0} to my Github named {1}";
            str = string.Format(str, "My friends", "amaalselim");
            Console.WriteLine(str);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            double salary = 1000;
            string s = "Your Salary is : {0}";
            s = string.Format(s, salary);
            Console.WriteLine(s);
        }

    }
}