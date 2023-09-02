namespace dsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee{Id = 804619442,Name = "Amaal",salary = 1000m,Department = "cs"};
            employee e2 = new employee { Id = 804619442, Name = "Amaal", salary = 1000m, Department = "cs" };
            //Console.WriteLine(e1 == e2);// (references) output : False
           // Console.WriteLine(e1.Equals(e2));  false ??? default output is compare (references) .
            // after intialize equal override method :
            Console.WriteLine(e1.Equals(e2));   //output : true ; (content)
            Console.WriteLine(e1 == e2); // output : true ;  (content)
            

        }
    }
    class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal salary { get; set; }
        public string Department { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || (!(obj is employee)))
                return false;
            var emp = obj as employee;
            return this.Id == emp.Id
                &&this.Name == emp.Name
                &&this.salary == emp.salary
                &&this.Department == emp.Department;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (7* hash) + Id.GetHashCode();
            hash = (7*hash) + Name.GetHashCode();
            hash = (7*hash) + salary.GetHashCode();
            hash = (7*hash) + Department.GetHashCode();
            return hash;
        }
        public static bool operator == (employee lhs , employee rhs)=> lhs.Equals(rhs);
        public static bool operator !=(employee lhs, employee rhs)=> !lhs.Equals(rhs);

    }
}