namespace Real_world
{
    internal class Realworld
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Manager m = new Manager(1000, "Amaal s.", 180, 10);
            Mantianence ms = new Mantianence(900, "Retaj s.", 150, 5);

            Sales s = new Sales(1100, "Hussein M.", 200, 20,0.05m,10000m);

            Develper d = new Develper(1000, "Esraa H.", 190, 15,true);

            Employee[] employees = { m, ms, s, d };
            foreach(var employee in employees)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(employee);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n-------------------------------------");
            }
            Console.ReadKey();
        }
         
        
    }

}