
using mainprogram.mathexpression;

namespace mathexpression
{
    public static class app
    {
        public static void Run(string[] args)
        {
            while(true)
            {
                Console.Write("Please enter math expression : ");
                var input = Console.ReadLine();
                var expr = expression_parser.Parse(input);
                Console.ForegroundColor = ConsoleColor.Magenta;
                
                Console.WriteLine($"leftsideoperand: {expr.leftsideoperant} , operation: {expr.operation} , rightsideoperand: {expr.rightsideoperant}");
                Console.WriteLine($"{input} = {evaluateexpression(expr)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("========================================================================================================================");
            }
            
        }
        private static object evaluateexpression(mathexpreesion expr)
        {
            if (expr.operation == mathoperation.Addition)
            {
                return expr.leftsideoperant + expr.rightsideoperant;
            }
            else if (expr.operation == mathoperation.Substraction)
            {
                return expr.leftsideoperant - expr.rightsideoperant;
            }
            else if (expr.operation == mathoperation.multiplication)
            {
                return expr.leftsideoperant * expr.rightsideoperant;
            }
            else if (expr.operation == mathoperation.Division)
            {
                return expr.leftsideoperant / expr.rightsideoperant;
            }
            else if (expr.operation == mathoperation.modulus)
            {
                return expr.leftsideoperant % expr.rightsideoperant;
            }
            else if (expr.operation == mathoperation.power)
            {
                return Math.Pow(expr.leftsideoperant, expr.rightsideoperant);
            }
            else if (expr.operation == mathoperation.sin)
            {
                return Math.Sin(expr.rightsideoperant);
            }
            else if (expr.operation == mathoperation.cos)
            {
                return Math.Cos(expr.rightsideoperant);
            }
            else if (expr.operation == mathoperation.tan)
            {
                return Math.Tan(expr.rightsideoperant);
            }
            return 0;
        }
    }
}