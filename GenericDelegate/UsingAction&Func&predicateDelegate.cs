namespace k
{
    internal class GenericDelegate
    {
        public delegate bool filter<in T>(T n);
        static void Main(string[] args)
        {
            IEnumerable<int> list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            printnumbers(list, n => n <= 6,()=>Console.WriteLine("============================="));
            printnumbers(list, n => n <= 7,() => Console.WriteLine("============================="));
            printnumbers(list, n => n%2==0, () => Console.WriteLine("============================="));
            IEnumerable<decimal> list2 = new decimal[] { 1.0m, 2.55m, 3.34m, 4.32m, 5.55m, 6.66m, 7.344m, 8.98m, 9.10m };
            printnumbers(list2, n => n > 5.99m, () => Console.WriteLine("============================="));
        }
        static void printnumbers<T>(IEnumerable<T> numbers, Predicate<T> f,Action action)
        {
            
            foreach (var n in numbers)
            {
                if (f(n)) Console.WriteLine(n);
            }
            action();
        }
    }
}