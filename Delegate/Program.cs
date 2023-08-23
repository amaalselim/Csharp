using System.Reflection.Metadata.Ecma335;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id =1 , Name ="Amaal" , Gender="F",Totalsales=65000m},
                new Employee {Id =2 , Name ="Ahmed" , Gender="M",Totalsales=50000m},
                new Employee {Id =3 , Name ="Mohamed" , Gender="M",Totalsales=40000m},
                new Employee {Id =4 , Name ="Retaj" , Gender="F",Totalsales=30000m},
                new Employee {Id =5 , Name ="Aya" , Gender="F",Totalsales=16000m},
                new Employee {Id =6 , Name ="Esraa" , Gender="F",Totalsales=15000m}
            };
            var report = new report();
            report.processemployee(emps, "sales >=$60,0000",s => s.Totalsales > 60000m);
            report.processemployee(emps, " sales>=$30,000 And sales <=$59,999",s=> s.Totalsales >= 30000m && s.Totalsales < 60000m);
            report.processemployee(emps, "sales <=$30,0000",s=> s.Totalsales < 30000m);
            Console.ReadKey();
        }
    }
 }