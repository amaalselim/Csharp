namespace G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Firstname: ");
                var fname = Console.ReadLine();
                Console.Write("Lastname: ");
                var lname = Console.ReadLine();
                Console.Write("HireDate: ");
                DateTime? hiredate = null;
                if (DateTime.TryParse(Console.ReadLine(), out DateTime hdate))
                {
                    hiredate = hdate;
                }
                var empid = Generator.GenerateID(fname, lname, hdate);
                var randompassword = Generator.GenerateRandomPassword(10);
                Console.WriteLine($"{{\n\nId: {empid},\nfirstname: {fname},\nlastname: {lname},\nhiredate: {hdate},\npassword: {randompassword}\n\n}}");

            } while (1 == 1);
        }
    }
    /// <include file="Generator.xml" path='docs/members[@name="generator"]/Generator/*'/>
    public class Generator
    {
        
        public static int LastIdSequence { get;private set; }
        public static string GenerateID(string fname, string lname, DateTime? hiredate)
        {
            // II YY MM DD 01
            if (fname is null)
            {
                throw new InvalidOperationException($"{nameof(fname)} cannot be null");
            }
            if (lname is null)
            {
                throw new InvalidOperationException($"{nameof(lname)} cannot be null");
            }
            if (hiredate is null)
            {
                hiredate = DateTime.Now;
            }
            else
            {
                if (hiredate.Value.Date < DateTime.Now.Date)
                {
                    throw new InvalidOperationException($"{nameof(hiredate)} cannot be in the past");
                }
            }
            var yy = hiredate.Value.ToString("yy");
            var mm = hiredate.Value.ToString("MM");
            var dd = hiredate.Value.ToString("dd");
            var code = $"{fname.ToUpper()[0]}{lname.ToUpper()[0]} {yy} {mm} {dd} {(++LastIdSequence).ToString().PadLeft(2, '0')}";
            return code;
        }
        public static string GenerateRandomPassword(int length)
        {
            const string validscope = "abcdefghijklmnopqrstuvwzyzABCDEFGHIJKLMNOPQRSTUVWZYZ1234567890";
            var result = "";
            Random rnd = new Random();
            while (0 < length--)
            {
                result += validscope[(rnd.Next(validscope.Length))];
            }
            return result;
        }
    }
}