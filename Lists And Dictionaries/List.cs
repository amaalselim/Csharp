namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Egypt = new Country { Name = "EGYPT", Isocode = "EGY" };
            var Brazil = new Country { Name = "BRAZIL", Isocode = "BRA" };
            var IRaq = new Country { Name = "IRAQ", Isocode = "IRQ"};
            
            Country[] countryarray = new Country[] 
            {  
                Egypt, Brazil, IRaq 
             };
            List<Country> countries = new List<Country>(3);  //list
            // Add item to list
            countries.Add(new Country { Name = "UNTITED STATE", Isocode = "USA" });// O(1)
            countries.AddRange(countryarray);// O(1)
            countries.Insert(1, new Country { Name = "ARGANTINE", Isocode = "ARG" });// O(n);
            Print(countries);
            
            //Remove(item)from list
            countries.RemoveAt(4);
            countries.RemoveAll(X => X.Name.EndsWith("NE"));
            countries.Remove(new Country { Name = "EGYPT", Isocode = "EGY" });
            Print(countries);
        }
        
        static void Print(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine($"count: {countries.Count}");//actual count
            Console.WriteLine($"Capacity: {countries.Capacity}");//initial capacity for user

        }
    }

    class Country
    {
        public string Isocode { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}({Isocode})"; // EGYPT (EGY)
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                hash = hash * 23 + Name.GetHashCode();
                hash= hash * 23 + Isocode.GetHashCode();
                return hash;
            }
        }
        public override bool Equals(object obj)
        {
            var country = obj as Country;
            if (country is null) return false;
            return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase)
            && this.Isocode.Equals(country.Isocode, StringComparison.OrdinalIgnoreCase);
        }

    }

}
