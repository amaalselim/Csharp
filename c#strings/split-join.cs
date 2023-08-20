using Microsoft.VisualBasic;

namespace strings
{
    internal class stringformatting
    {
        static void Main(string[] args)
        {
            // split string (convert string to array separated by comma)
            Console.Write("Please enter list of numbers separated by comma : ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(",");
            int sum = 0;
            foreach (string number in numbers)
                sum += int.Parse(number);
            Console.WriteLine("Average = " + sum / numbers.Length);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // join string (convert array to string )
            string[] words = { "Hello", "to", "my", "github" };
            string statement = string.Join(" ", words);
            Console.WriteLine(statement);
        }


    }
}