namespace Real_world
{
    public class Employee
    {
        private const int minimumloggedhours = 175;
        private const decimal overtimerate = 1.25m;

        protected Employee(int id, string name, decimal loggedhours, decimal wage)
        {
            Id = id;
            Name = name;
            this.loggedhours = loggedhours;
            this.wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal loggedhours { get; set; }
        protected decimal wage { get; set; }
        protected virtual decimal calculate()
        {
            return calculateBasesalary() + calculateOvertime();
        }
        protected decimal calculateBasesalary()
        {
            return wage * loggedhours;
        }
        protected decimal calculateOvertime()
        {
            var additionalhours = ((loggedhours - minimumloggedhours) > 0 ? loggedhours - minimumloggedhours : 0);
            return additionalhours * wage * overtimerate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Real_world.", "");
            return $"{type}"+
                   $"\nId : {Id}" +
                   $"\nName : {Name}" +
                   $"\nLoggedHours : {loggedhours} hrs" +
                   $"\nWage : {wage} $/hr"+
                   $"\nBsesalary :${Math.Round(calculateBasesalary(),2):N0}" +
                   $"\novertime :${Math.Round(calculateOvertime(), 2):N0}";


        }
    }

}