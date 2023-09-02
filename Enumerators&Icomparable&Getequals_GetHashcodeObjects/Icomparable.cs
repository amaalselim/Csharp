namespace kiki
{
    internal class Icomparable
    {
        static void Main(string[] args)
        {
            var temps = new List<Tempreture>();
            Random rnd = new Random();
            for(var i = 0; i < 100; i++)
            {
                temps.Add(new Tempreture(rnd.Next(-30, 50)));
            }
            temps.Sort();
            foreach(var temp in temps)
            {
                Console.WriteLine(temp.value);
            }
            
        }
    }
    class Tempreture : IComparable
    {
        private int _value;
        public int value => _value;
        public Tempreture(int value)
        {
             _value = value;
        }

        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;
            var temp = obj as Tempreture;
            if (temp is null)
            {
                throw new ArgumentException("object is not a tempreture object");
            }
            return this._value.CompareTo(temp._value);
        }
    }
}