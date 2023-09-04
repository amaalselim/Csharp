using System.ComponentModel;

namespace HashSet
{
    internal class HashSet
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
               new Customer {name="Amaal S.",telephone="+1 123 123 4567"},
               new Customer {name="Retaj L.",telephone="+1 123 123 4568"},
               new Customer {name="Ahmed M.",telephone="+1 123 123 4564"},
               new Customer {name="Khaled K.",telephone="+1 123 123 4560"},
               new Customer {name="Hossam A.",telephone="+1 123 123 4563"}
            };
            var custhashset1 = new HashSet<Customer>(customers);
            //custhashset1.Add(new Customer { name = "Amaal S.", telephone = "+1 123 123 4567" }); // ignore this

            var customers2 = new List<Customer>
            {
               new Customer {name="Reem A.",telephone="+1 5463 123 4567"},
               new Customer {name="Aya L.",telephone="+1 1093 123 4568"},
               new Customer {name=" Hossam A.",telephone="+1 123 123 4563"}
            };
            var custhashset2= new HashSet<Customer>(customers2);
            custhashset1.UnionWith(custhashset2);
            //custhashset1.IntersectWith(custhashset2);
            //custhashset1.ExceptWith(custhashset2);
            Console.WriteLine("Hash Set");
            Console.WriteLine("-----------------");
            foreach (var customer in custhashset1)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Set");
            Console.WriteLine("-----------------");
            var custsortedset = new SortedSet<Customer>(customers);
            custsortedset.Add(new Customer { name = "Baraa K.", telephone = "+1 123 7684 4563" });
            foreach (var customer in custsortedset)
            {
                Console.WriteLine(customer);
            }

        }
    }
    class Customer : IComparable<Customer>
    {
        public string name { get; set; }
        public string telephone { get; set; }
        public override string ToString()
        {
            return $"{name} ({telephone})";
        }
        public override int GetHashCode()
        {
            var hash = 17;
            hash= hash * 23 + telephone.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if(customer is null) return false;  
            return this.telephone.Equals(customer.telephone);
        }

        public int CompareTo(Customer other)
        {
            if(object.ReferenceEquals(this, other)) return 0; 
            if(other is null) return -1;
            return this.name.CompareTo(other.name);
        }
    }
}
