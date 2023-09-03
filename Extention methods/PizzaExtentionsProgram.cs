namespace ConsoleApp3
{
    internal class Methodchaning
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            p.AddDough("thin");
            p.AddSauce();
            p.AddCheeze(true);
            p.AddTopping("black Olives", 3.5m);
            Console.WriteLine("your pizza : ");
            Console.WriteLine(p);
        }
    }
    static class PizzaExtentions
    {
        public static Pizza AddDough(this Pizza value , string type)
        {
            value.Content += $"{type} Dough X $4.00";
            value.Totalprice += 4m;
            return value ;  
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"\nTomato Sauce X $2.00";
            value.Totalprice += 2m;
            return value;
        }
        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"\n{(extra?"extra":"regular")} cheeze Sauce X ${(extra ? "6.00" : "4.00")}";
            value.Totalprice += extra ? 6m : 4m;
            return value;
        }
        public static Pizza AddTopping(this Pizza value, string type,decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.Totalprice += price;
            return value;
        }
    }
    class Pizza
    {
        public string Content { get; set; }
        public  decimal Totalprice { get; set; }
        public override string ToString()
        {
            return $"{Content}\n--------------------------\nTotalprice: ${Totalprice.ToString("#.##")}";
        }
    }
}
