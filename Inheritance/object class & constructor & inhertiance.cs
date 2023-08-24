namespace dldl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a); // output : namespace.Animal
            a.Name = "DOG";
            Console.WriteLine(a.ToString()); // output : Animal : DOG
            var e = new Eagle();
            Console.WriteLine(e.GetType()); //output  namespace.Eagle 
            

            Eagle e2 = new Eagle(123); // constructor not accessible 

        }
    }
     class Animal : Object
    {
        public int x;
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Animal : {Name}";  
        }
        public Animal()
        {
             
        }
        public Animal(int value)
        {
             x=value;
        }
    }
    class Eagle : Animal
    {
        public Eagle()
        {
             
        }
        public Eagle(int e2value) : base (e2value) // its ok we have constructor 
        {
             
        }


    }
}