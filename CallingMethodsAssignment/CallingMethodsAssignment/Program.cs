using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //calling methods here, inputting num1
            int result1 = Math.MultiplyBy72(num1);
            int result2 = Math.DivideBy3(num1);
            int result3 = Math.Add59(num1);

            Console.WriteLine(num1 + " multiplied by 72 is " + result1);
            Console.WriteLine(num1 + " divided by 3 is " + result2);
            Console.WriteLine(num1 + " added by 59 is " + result3);
            Console.ReadLine();
        }


        
    }
}
