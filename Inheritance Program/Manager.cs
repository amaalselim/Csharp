namespace Real_world
{
    public class Manager : Employee
    {
        private const decimal allowancerate = 0.05m;
        public Manager(int id, string name, decimal loggedhours, decimal wage) : base(id, name, loggedhours, wage)
        {

        }
        protected override decimal calculate()
        {
            return base.calculate() + calculateallowance();
        }
        private decimal calculateallowance()
        {
            return base.calculate() + base.calculate() * allowancerate;
        }
        public override string ToString()
        {
            return base.ToString() +
             $"\nAllowance : ${Math.Round(calculateallowance(), 2):N0}" +
             $"\nnet salary : ${Math.Round(this.calculate(), 2):N0}";
        }

    }
}