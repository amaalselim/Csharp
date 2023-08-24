namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e = new Eagle();
            Animal a = e;    // Upcasting (create a base class peference from a subclass)
            Eagle e2 = (Eagle)a; // down casting (create a sub class peference from a baseclass)
                                 // Folcan f = (Folcan)a;  cant convert from eagle to folcan 
           // Folcan f = a as Folcan; // if cannot return null ;
            if(a is Folcan)
            {
                Console.WriteLine("a is a folcan");
            }
            else
            {
                Console.WriteLine("a is not a folcan");
            }

        }
    }
    class Animal
    {
        public void move()
        {
            Console.WriteLine("Moving");
        }
    }
    class Eagle : Animal 
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
    class Folcan : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}