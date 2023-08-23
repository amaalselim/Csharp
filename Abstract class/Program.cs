namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle { length = 2, width = 2, };
            s.printarea();
            s = new circle { radius = 5 };
            s.printarea();

        }
    }
}