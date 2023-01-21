using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Math
    {
        //First method allows multiplication by 72
        public static int MultiplyBy72(int num1)
        {
            int mult;
            mult = num1 * 72;
            return mult;

        }

        //second method dives by 3
        public static int DivideBy3(int num1)
        {
            int div;
            div = num1 / 3;
            return div;
        }

        //third method
        public static int Add59(int num1)
        {
            int add;
            add = num1 + 59;
            return add;
        }

    }

        
}
