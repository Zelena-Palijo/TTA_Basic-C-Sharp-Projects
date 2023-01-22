using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = Math.Sum(num1, num2); // call the method, but void 
            Console.WriteLine(num1 + " plus " + num2 + " equals " + result);
            Console.ReadLine();

            //cannot run due to void method?
        }
    }
}
