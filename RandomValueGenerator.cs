using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Select An Option : ");
                Console.WriteLine("[1] Please Enter Random Number   [2] Please Enter Random String");
                string selectedoption = Console.ReadLine();
                if (selectedoption == "1")
                    GenerateRandomNumber();
                else if (selectedoption == "2")
                    GenerateRandomString();
                Console.WriteLine("===========================================================================");
            }
        }
        //=====================================================================
        public static void GenerateRandomNumber()
        {
            Console.Write("Enter Minimum Value of Range : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Maximum Value of Range : ");
            int max = Convert.ToInt32(Console.ReadLine());
            var rnd = new Random();
            var value = rnd.Next(min, max);
            Console.WriteLine($"RAandomNumber : {value}");
        }
        //==================================================================
        private const string bcapital = "ABCDEFGHIJKLMNOBQRSTWXYZ";
        private const string bsmall = "abcdefghijklmnobqrstwxyz";
        private const string bnum = "01234567890";
        private const string bsymbol = "~!@#$%^&*()";
        //==================================================================
        public static void GenerateRandomString()
        {
            Console.WriteLine("Please Select Buffer Option (enter yes/no) : ");
            Console.Write($"[1] Include Capital Letters?(yes/no)");
            string selectedbuffer1 = Console.ReadLine();
            Console.Write($"[2] Include Small Letters?(yes/no)");
            string selectedbuffe2 = Console.ReadLine();
            Console.Write($"[3] Include Numbers(yes/no)");
            string selectedbuffer3 = Console.ReadLine();
            Console.Write("[4] Include Symbols?(yes / no)");
            string selectedbuffer4 = Console.ReadLine();
            string buffer = "";
            if (selectedbuffer1 == "yes")
            {
               buffer += bcapital;
            }if (selectedbuffe2 == "yes")
            {
                buffer += bsmall;
            }if (selectedbuffer3 == "yes")
            {
                buffer += bnum;
            }if (selectedbuffer4 == "yes")
            {
                buffer += bsymbol;
            }else
            {
                buffer += "Invalid please try again ";
            }
            Console.Write("Enter String Length : ");
            int str = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();
            var rnd = new Random();
            if (str < 0)
            {
                Console.WriteLine("length cannot be under zero");
                return;
            }
            while (sb.Length < str)
            {
                var randomindex = rnd.Next(0,buffer.Length-1);
                sb.Append(buffer[randomindex]);
            }
            Console.WriteLine($"Randomstring : {sb}");
        }
    }
}