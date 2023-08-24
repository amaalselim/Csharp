namespace Real_world
{
    public class Sales : Employee
    {
        protected decimal salesvolume { get;set; }
        protected decimal commission { get;set; }
        public Sales(int id, string name, decimal loggedhours, decimal wage,
            decimal salesvolume,decimal commission) : base(id, name, loggedhours, wage)
        {
            this.salesvolume = salesvolume;
            this.commission = commission;
        }
        protected override decimal calculate()
        {
            return base.calculate() + calculateBonus();
        }
        private decimal calculateBonus()
        {
            return salesvolume * commission;
        }
        public override string ToString()
        {
            return base.ToString() +
             $"\nCommission: ${Math.Round(commission, 2):N0}" +
             $"\nBonus : ${Math.Round(calculateBonus(), 2):N0}" +
             $"\nnet salary : ${Math.Round(this.calculate(), 2):N0}";
        }

    }
}