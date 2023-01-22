using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Math
    {
        //first method
        public static int MultiplyBy5(int num1, int num2 = 2) //num2 is defined, and optional
        {
            int mult;
            mult = num1 * 5 * num2; //default will multiple by 10
            return mult;
        }
    }
}
