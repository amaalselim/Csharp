namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Print; // cannot return value ;
            action("Amaal");
            Func<int, int, int> func = Add; // return value ;
            Console.WriteLine(func(1, 2));
            Predicate<int> predicate = IsEven; // return value (bool) => true or false;
            Console.WriteLine(predicate(4));
        }
        static void Print(string s) => Console.WriteLine(s);
        static int Add(int n1 , int n2) => n1 + n2;
        static bool IsEven(int n) => n % 2 == 0;
    }
}