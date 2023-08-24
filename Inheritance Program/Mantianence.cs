namespace Real_world
{
    public class Mantianence : Employee
    {
        private const decimal Hardship = 100m;
        public Mantianence(int id,string name , decimal loggedhours, decimal wage) : base(id,name, loggedhours, wage)
        {
             
        }
        protected override decimal calculate()
        {
            return base.calculate() + Hardship;
        }

        public override string ToString()
        {
            return base.ToString() +
             $"\nHard ship : ${Math.Round(Hardship, 2):N0}" +
             $"\nnet salary : ${Math.Round(this.calculate(), 2):N0}";
        }

    }
}