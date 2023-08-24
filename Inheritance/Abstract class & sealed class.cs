namespace jj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();// cannot create instance of abstract class 
    }
   abstract class Animal // to inherited only .
    {
        public void walk()
        {
            Console.WriteLine("walking");
        }
    }
   sealed class Eagle : Animal        // sealed class : can't be inherited.
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
   // class AmericanEagle : Eagle         // error 
     
}