namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayofnumbers = { 1, 2, 3, 4, 5 };
            int[] arrayofnumbers2 = { 6, 100, 28, 5, 39 };
            calculatavg(arrayofnumbers);
            calculatavg(arrayofnumbers2);
        }
        static void calculatavg(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
             sum += number;
            double avg = sum / numbers.Length;
            Console.WriteLine($"Avg of numbers is : {avg}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}