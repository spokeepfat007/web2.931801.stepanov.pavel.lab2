using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend2.Models
{
    public class Actions
    {
        public string val1 { get; set; }
        public string val2 { get; set; }
        public string oper { get; set;}

        public string getResult()
        {

            int a = Int32.Parse(val1);
            int b = Int32.Parse(val2);
            switch ((int)Convert.ToChar(oper))
            {
                case 42: return (val1) + " * " + (val2) + " = " + (a * b);
                case 43: return (val1) + " + " + (val2) + " = " + (a + b);
                case 45: return (val1) + " - " +(val2) + " = " +(a-b);
                case 47:
                    try
                    {
                        return (val1) + " / " + (val2) + " = " + (a / b);
                    }
                    catch (DivideByZeroException)
                    {
                        return "Exception: Division by zero.";
                    }
                    
            }
            return "b";
        }
    }
}
