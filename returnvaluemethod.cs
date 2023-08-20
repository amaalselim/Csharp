namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayofnumbers = { 1, 2, 3, 4, 5 };
            int[] arrayofnumbers2 = { 6, 100, 28, 5, 39 };

            Console.WriteLine(calculatavg(arrayofnumbers));
            Console.WriteLine(calculatavg(arrayofnumbers2, true));
        }
        static double calculatavg(int[] numbers, bool printasumtoconsole = false)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            double avg = sum / numbers.Length;
            if (printasumtoconsole)
            {
                Console.WriteLine("sum = " + sum);
            }
            Console.Write($"Avg of numbers is : ");
            return avg;
        }
    }
}