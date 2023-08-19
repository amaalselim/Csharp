namespace INdexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter segment1 : ");
            int segment1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter segment2 : ");
            int segment2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter segment3 : ");
            int segment3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter segment4 : ");
            int segment4 = Convert.ToInt32(Console.ReadLine());
            IP ip = new IP(segment1, segment2, segment3, segment4);
            Console.WriteLine($"Your IP Address is : {ip.Address}");
            Console.WriteLine();
            Console.Write("Enter index to display value : ");
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                var indexes = ip[index];
                Console.WriteLine($"The Value With Index {index} is : {indexes}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("so Please Enter index in the range of array");
            }


        }
    }
    public class IP
    {
        private int[] segments = new int[4];
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }
        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }
        public string Address => string.Join(".", segments);
    }
}