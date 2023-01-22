using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Math
    {
        //Method 1 - Void, divide by 2
        public static void Half(int num1)
        {
            Console.WriteLine("Half of " + num1 + " equals " + (num1 / 2));
            Console.ReadLine();
        }

        //Method 2 - output parameters
        public static int Add10(int num2, out string message)
        {
            int add;
            add = num2 + 10;
            message = "It's been done.";
            return add;
        }

        //Methods 3,4 Overloading method
        public static int Multiplyby10(int num3)
        {
            int mult;
            mult = num3 * 10;
            return mult;
           
        }

        public static int Multiplyby10(int num3, int num4)
        {
            int mult;
            mult = num3 * 10 + num4;
            return mult;
        }

    }
}
