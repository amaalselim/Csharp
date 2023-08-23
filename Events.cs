namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amaal");
            stock.Price = 100;
            stock.onpricechanges += Stock_onpricechanges;
            stock.changestockpriceby(0.07m);
            stock.changestockpriceby(-0.03m);
            stock.changestockpriceby(0.00m);
            stock.onpricechanges+= Stock_onpricechanges;
            stock.changestockpriceby(0.08m);


        }

        private static void Stock_onpricechanges(Stock stock, decimal oldprice)
        {
            string result = "";
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                result = "up";
            }
            else if (stock.Price < oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "Down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name} : {stock.Price} {result}");
        }
    }
    public class Stock
    {
        private string name;
        private decimal price;

        public delegate void stockpricechangedhandler (Stock stock, decimal oldprice);
        public event stockpricechangedhandler onpricechanges;
        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }
        public Stock(string stockname)
        {
            this.name = stockname;
        }
        public void changestockpriceby(decimal percent)
        {
            decimal oldprice = this.price;
            this.price += Math.Round(this.Price * percent, 2);
            if(onpricechanges != null)
            {
                onpricechanges(this, oldprice);
            }
        }

    }
}