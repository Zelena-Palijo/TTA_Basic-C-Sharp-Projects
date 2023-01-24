using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // instantiate the class

            //calling first method
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(Optional) Pick a second number.");
            string checkNum2 = Console.ReadLine();

            //shows error if no input, so use if/else to handle this
            // if user inputs something then convert to int and proceed 
            if (!string.IsNullOrEmpty(checkNum2))
            {
                int num2 = Convert.ToInt32(checkNum2);
                //when above is processed, throws error that input method doesn't work
                //worked the first time, but when input for second is 2, then error
                int result2 = math.MultiplyBy5(num1, num2);
                Console.WriteLine(result2);
                Console.ReadLine();
            }
            else
            {
                //int num2 = 2; // have to declare here, but method should already do this?s
                int result = math.MultiplyBy5(num1);
                Console.WriteLine(result);
                Console.ReadLine();
            }

            //int result1 = Math.MultiplyBy5(num1, num2);
            //Console.WriteLine(num1 + " multiplied by 5 and then by {0} equals " + result1, num2);
            Console.ReadLine();
        }
    }
}
