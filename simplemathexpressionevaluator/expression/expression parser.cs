using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace mainprogram.mathexpression
{
    public static class expression_parser
    {
        private const string mathsymbol = "+*^%/";
        
        public static mathexpreesion Parse(string input)
        {
            bool leftsideintialized = false;
            var expr = new mathexpreesion();
            string token = "";
            for ( var i =0;i< input.Length; i++)
            {
                var currentchar = input[i];
                if (char.IsDigit(currentchar))
                {
                    token += currentchar;
                    if (i == input.Length - 1)
                    {
                        expr.rightsideoperant=double.Parse(token);
                        break;   
                    }
                }
                else if (mathsymbol.Contains(currentchar))
                {
                    if (!leftsideintialized)
                    {
                        expr.leftsideoperant = double.Parse(token);
                        leftsideintialized = true;
                    }
                    
                    expr.operation = parsemethodoperation(currentchar.ToString());
                    token = "";
                }
                else if (char.IsLetter(currentchar))
                {
                    token += currentchar;
                    leftsideintialized = true;
                    
                }
                else if(currentchar==' ')
                {
                    if (!leftsideintialized)
                    {
                        expr.leftsideoperant=double.Parse(token);
                        leftsideintialized=true;
                        token = "";
                    }
                    else if (expr.operation == mathoperation.None)
                    {
                        expr.operation= parsemethodoperation(token);
                        token = "";
                    }
                }
                else if (currentchar == '-' && i>0)
                {
                    if(expr.operation == mathoperation.None)
                    {
                        expr.operation = mathoperation.Substraction;
                        expr.leftsideoperant= double.Parse(token);
                        leftsideintialized = true;
                        token = "";
                    }
                    else
                    {
                        token += currentchar;
                    }
                }
                else
                {
                    token += currentchar;

                }
            }
            return expr;
        }

        private static mathoperation parsemethodoperation(string operation)
        {
            switch (operation.ToLower())
            {
                case "+":
                    return mathoperation.Addition;
                case "*":
                    return mathoperation.multiplication;
                case "/":
                    return mathoperation.Division;
                case "-":
                    return mathoperation.Substraction;
                case "%":
                case "mod":
                    return mathoperation.modulus;
                case "^":
                case "pow":
                    return mathoperation.power;
                case "sin":
                    return mathoperation.sin;
                case "cos":
                    return mathoperation.cos;
                case "tan":
                    return mathoperation.tan;
                default:
                    return mathoperation.None;
            }
        }
    }
}
