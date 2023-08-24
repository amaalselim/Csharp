using System.Reflection.Metadata.Ecma335;

namespace troubleshooting
{
    internal class troubleshooting
    {
             /*
             Types of Errors : 
             1- Syntax Errors.
             2- Run time Errors.
             3-Logical Errors.
             */
        static void Main(string[] args)
        {
            // 1- Syntax Errors:
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x); // if I forget ; => so I have Syntax error .
                // I can see Error fron Error list window .
                x++;
            }
            Console.WriteLine("===========================================");
            //2- Runtime Errors:
            var amount = 1000;
            var members = 2;
            members = Reduce(members,2);
            var result = Distribute(amount, members);
            Console.WriteLine(result);
            Console.WriteLine("===========================================");
            var f = convertcelisiustofehrenhiet(0);
            Console.WriteLine($"{0} c = {f} f");
            var c = convertfehrenhitetocelisius(32);
            Console.WriteLine($"{32} f = {c} c");
        }
        static int Reduce(int members,int value)
        {
            return members-=value; // 2-2 = 0 
        }
        static int Distribute(int amount, int members)
        {// I handle Exception using try catch finally statement;
            try
            {
                return amount / members;   // 1000/0 ( EXception Error ) ; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"message error : {ex.Message}");// error message ;
            }
            finally
            {
                //cleanups;
            }
            return 0;
            //output : attemped to divided by zero ;
        }
           
        // logical Errors : occurs when program is written fine but doesn't produce design result;
        static decimal convertcelisiustofehrenhiet(decimal celicius)
        {
            var fehrenhite = 0m;
            fehrenhite = (celicius * 9 / 5) + 32;
            return fehrenhite;
        }
        static decimal convertfehrenhitetocelisius(decimal fehrenhite)
        {
            var celisius= 0m;
            celisius= (fehrenhite -32) *9/5; /* if I write fehrenhite -32*9/5 
                                              code runs but result false */
            return celisius;
        }
        /*
         how can I solve LOGICAL ERRORS : 
         -by tracing التتبع (break point) walk by code line by line 
        */
    }
}