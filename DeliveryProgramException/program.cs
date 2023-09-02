namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var delivery = new Delivery{Id=804619442,CustomerName="Amaal",Address="Damietta"};
            var Service = new DeliveryService();
            Service.Start(delivery);
            Console.WriteLine(delivery);
        }

    }
}
    