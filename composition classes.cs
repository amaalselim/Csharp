namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new employee();
            Console.WriteLine(emp.employeeinsurance.policyname);
        }


    }
    class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public insurance employeeinsurance { get; set; }
        class department
        {
        public int Id { get; set; } 
        public string Name { get; set; }
        }
        public employee()
        {
             employeeinsurance = new insurance { policyid= -1 , policyname= "N/A" };
        }
    }
    
    class insurance
    {
        public int policyid { get; set; }
        public string policyname { get; set; }
    }

}