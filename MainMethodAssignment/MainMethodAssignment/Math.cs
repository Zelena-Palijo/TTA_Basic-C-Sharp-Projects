using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        //First method
        public static int MultiplyBy5(int num1)
        {
            int mult;
            mult = num1 * 5;
            return mult;
        }

        //second method, bring in decimal return to int
        public static int MultiplyBy5(decimal num2)
        {
            int num3 = Convert.ToInt32(Convert.ToDecimal(num2));
            int mult;
            mult = num3 * 5; //since come in decimal, convert to int
            return mult;
        }

        //third method, bring in string return to int
        public static int MultiplyBy5(string num4)
        {
            int num5 = Convert.ToInt32(num4);
            int mult;
            mult = num5 * 5; // since come in as string, convert to int
            return mult;
        }
    }
}
