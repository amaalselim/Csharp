namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;   //output : 3/9/2023 4:51:07 AM
            dt =dt.AddDays(6);
            Console.WriteLine($"Datetime.Now : {dt}");  //output : 9/9/2023 4:51:07 AM
            //Console.WriteLine($"IsweekEnd: {DateTimehelper.IsweekEnd(dt)}");//output: true 
            //Console.WriteLine($"IsweekDay: {DateTimehelper.IsweekDay(dt)}");//output: false
            Console.WriteLine($"IsweekEnd: {dt.IsweekEnd()}");//output: true 
            Console.WriteLine($"IsweekDay: {dt.IsweekDay()}");//output: false
            Console.WriteLine($"Is leap year : {DateTime.IsLeapYear(2020)}"); //output: true


        }
    }
}