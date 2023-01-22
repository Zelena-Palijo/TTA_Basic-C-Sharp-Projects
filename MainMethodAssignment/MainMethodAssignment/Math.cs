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
        public static int DivideBy2(float num1)
        {
            int div;
            div = Convert.ToInt32(num1 / 2); //since come in float, convert to int
            return div;
        }
    }
}
