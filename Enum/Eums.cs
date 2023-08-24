namespace ENUMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Month.OCT);
            Console.WriteLine((int)Month.OCT);
            Console.WriteLine("================================================");
            var day = DAY.saturday | DAY.monday;
            if(day.HasFlag(DAY.weekend))
            {
                Console.WriteLine("Enjoy your weekend");
            }
            Console.WriteLine("================================================");
            Console.WriteLine((int)Month.APR);
            Console.WriteLine(Month.MAY.ToString());
            Console.WriteLine("================================================");
            var d = "feb";
            if (Enum.TryParse(d,out Month month))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("INVALID!!!!!!!!!!");
            }
            Console.WriteLine("================================================");
            var D = "FEB";
            var l = 2;
            if (Enum.IsDefined(typeof(Month), D))
            {
                Console.WriteLine(Enum.Parse(typeof(Month), D));
                
            }
            if (Enum.IsDefined(typeof(Month), l))
            {
                Console.WriteLine((Month)l);
               
            }
            else
            {
                Console.WriteLine("INVALID!!!!!!!!!!");
            }
            Console.WriteLine("================================================");
            // loop in Enums :
            foreach(var m in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{m} {(int)Enum.Parse(typeof(Month),m)}");
            }

        }
    }

    enum Month
    {
        JAN=1,
        FEB,
        MAR,
        APR,
        MAY,
        JUNE,
        JULY,
        AUG,
        SEPT,
        OCT,
        NOV,
        DEC
    }
    [Flags]
    enum DAY
    {
        None =1,
        monday=2,
        tuesday=4,
        wednesday=8,
        thirsday=16,
        friday=32,
        saturday=64,
        sunday=128,
        weekend = saturday | monday
    }
}