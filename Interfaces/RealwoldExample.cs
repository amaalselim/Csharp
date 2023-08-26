namespace ConsoleApp7
{
    internal class RealwoldExample
    {
        static void Main(string[] args)
        {
           cash cash = new cash();
            cash.Pay(9999.99m); // output : Cash Payment : $10,000 
            Cashier V = new Cashier(new Visa());
            V.checkout(9999.99m); // output : Cash Payment : $10,000 
            Cashier D = new Cashier(new Debit());
            D.checkout(9999.99m); // output : Cash Payment : $10,000
            Cashier M = new Cashier(new MasterCard());
            M.checkout(9999.99m); // output : Cash Payment : $10,000
        }
    }
    interface IPayment
    {
        void Pay(decimal amount);
    }
    class Cashier
    {
        private IPayment pay;
        public Cashier(IPayment payment)
        {
             pay = payment;
        }
        public void checkout(decimal amount)
        {
            pay.Pay(amount);
        }
    }
    class cash : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment : ${Math.Round(amount, 2):N0}");
        }
    }
    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment : ${Math.Round(amount, 2):N0}");
        }
    }
    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment : ${Math.Round(amount, 2):N0}");
        }
    }
    class MasterCard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment : ${Math.Round(amount, 2):N0}");
        }
    }

}