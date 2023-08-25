namespace Real_world
{
    public class Develper: Employee
    {
        private const decimal commission = 0.03m;
        protected bool Taskcompleted { get; set; }
        public Develper(int id, string name, decimal loggedhours, decimal wage
            ,bool Taskcompleted) : base(id, name, loggedhours, wage)
        {
            this.Taskcompleted = Taskcompleted;
        }
        protected override decimal calculate()
        {
            return base.calculate() + calculateBonus();
        }
        private decimal calculateBonus()
        {
            if(Taskcompleted)
                return base.calculate()* commission;
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() +
             $"\nTask completed: {(Taskcompleted ? "Yes" : "No")}" +
             $"\nBonus : ${Math.Round(calculateBonus(), 2):N0}" +
             $"\nnet salary : ${Math.Round(this.calculate(), 2):N0}";
        }

    }
}
