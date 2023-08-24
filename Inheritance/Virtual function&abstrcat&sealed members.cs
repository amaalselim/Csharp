namespace kksk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e = new Eagle();
            e.walk(); // output : override 
            e.eat(); // output : eating
        }
    }
    abstract class Animal 
    {
        public virtual void walk() // i want to edit on it // take virtual 
        {
            Console.WriteLine("walking");
        }
        public abstract void eat();  // abstract method doesn't have body 
        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
     class Eagle : Animal {    
        public override void walk() // take override 
        {
            base.walk(); // base : keyword call base class member ;
            Console.WriteLine("override");
        }
        public override void eat() // must take body ;
        {
            Console.WriteLine("eating");
        }
        public sealed override void Fly() // can't be overriden in the derived class
        {
            Console.WriteLine("Flying");
        }
        
    }
    class Americaneagle : Eagle
    {
       // public override void fly()         // error !!!!!!!!!!!
    }
    
}