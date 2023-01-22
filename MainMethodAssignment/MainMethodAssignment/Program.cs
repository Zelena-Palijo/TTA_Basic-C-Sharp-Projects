using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling first method int > int
            Console.WriteLine("Please choose a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = Math.MultiplyBy5(num1);
            Console.WriteLine(num1 + " multiplied by 5 is " + result1);
            Console.ReadLine();

            //calling second method decimal >int
            Console.WriteLine("Please choose a number with a decimal.");
            decimal num2 = System.Convert.ToDecimal(Console.ReadLine()); // convert string to decimal
            int result2 = Math.DivideBy2(num1); // method will convert decimal values to int 

            Console.WriteLine(num1 + " divided by 2 is " + result2);
            Console.ReadLine();

            
        }
    }
}
