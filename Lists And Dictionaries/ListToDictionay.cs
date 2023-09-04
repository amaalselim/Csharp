namespace listToDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new List<employee> { 
                new employee { Id=100,Name="Amaal S.",ReportTo=null},
                new employee { Id=200,Name="Retaj S.",ReportTo=100},
                new employee { Id=300,Name="Reem A.",ReportTo=100},
                new employee { Id=400,Name="Ahmed D.",ReportTo=200},
                new employee { Id=500,Name="Mohamed R.",ReportTo=300},
                new employee { Id=600,Name="Aya E.",ReportTo=400}
            };
            //var manager = emps.GroupBy(X => X.ReportTo);
            var manager = emps.ToLookup(X => X.ReportTo).ToDictionary(X => X.Key??-1, X => X.ToList());
            foreach(var entry in manager)
            {
                if (entry.Key == -1) continue;
                var Manager= emps.FirstOrDefault(X=>X.Id ==entry.Key);
                Console.WriteLine($"{Manager}");
                foreach(var emp in entry.Value)
                {
                    Console.WriteLine($"\t\t \"{emp}\" ");
                }
            }
        }
    }
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ReportTo { get; set; }
        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}