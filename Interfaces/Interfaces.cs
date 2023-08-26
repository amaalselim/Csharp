namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vechile v = new Honda("BMW","new",2022);
            Iloader v2 = new caterpillor("", "new", 2022);
            v2.Load(); // output : loading
            IDrivable v3 = new Honda("BMW", "new", 2022);
            v3.stop();
            IDrivable v4 = new caterpillor("BMW", "new", 2022);
            v4.move();
            
            
            
        }
    }
    abstract class vechile
    {
        protected string Brand;
        protected string model;
        protected int year;

        public vechile(string brand, string model, int year)
        {
            Brand = brand;
            this.model = model;
            this.year = year;
        }
    }
    interface Iloader
    {
        void Load();
        void unload();
    }
    interface IDrivable
    {
        void move();
        void stop();
    }
    class Honda : vechile , IDrivable
    {
        public Honda(string brand, string model, int year) :base(brand,model,year)
        {
             
        }

        public void move()
        {
            Console.WriteLine("Moving");
        }

        public void stop()
        {
            Console.WriteLine("Stopping");
        }
    }
    class caterpillor : vechile , Iloader , IDrivable
    {
        public caterpillor(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }
        public void move()
        {
            Console.WriteLine("Moving");
        }

        public void stop()
        {
            Console.WriteLine("Stopping");
        }

        public void unload()
        {
                Console.WriteLine("unLoading");
        }
    }

}