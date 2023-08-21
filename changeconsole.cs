using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace emuns
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an Option : ");
            Console.WriteLine("[1] change Background color   [2] change foreground color");
            string selectedoption = Console.ReadLine();
            foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("Please Enter Color Name : ");
            string colorname= Console.ReadLine();
            ConsoleColor selectedcolor =(ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorname, true);
            if (selectedoption == "1")
                Console.BackgroundColor = selectedcolor;
            else if (selectedoption=="2")
                Console.ForegroundColor= selectedcolor;
            else
            {
                Console.WriteLine("Invalid Option!!!!!!!!!!!!");
            }
        }
        
    }
}