namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(10);
            var m2 = new Money(20);
            var m3 = m1 + m2;
            var m4 = m1 - m3;
            Console.WriteLine(m3.Amount);
            Console.WriteLine(m1 < m3);
            Console.WriteLine(m2 == m4);

        }

        public class Money
        {
            private decimal amount;
            public  decimal Amount => amount;
            public Money(decimal value)
            {
                 this.amount = value;
            }
            public static Money operator+ (Money a,Money b)
            {
                var value = a.Amount + b.Amount;
                return new Money (value);
            }
            public static Money operator -(Money a, Money b)
            {
                var value = a.Amount - b.Amount;
                return new Money(value);
            }
            public static bool operator >(Money a, Money b)
            {
                return a.Amount > b.Amount;
                
            }
            public static bool operator <(Money a, Money b)
            {
                return a.Amount < b.Amount;

            }
            public static bool operator ==(Money a, Money b)
            {
                return a.Amount == b.Amount;

            }
            public static bool operator !=(Money a, Money b)
            {
                return a.Amount != b.Amount;

            }
            public static Money operator ++(Money a)
            {
                var value = a.Amount;
                return new Money(++value);

            }

        }

    }
}