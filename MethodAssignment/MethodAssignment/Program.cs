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
            //calling first method
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional) Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result1 = Math.MultiplyBy5(num1, num2);
            Console.WriteLine(num1 + " multiplied by 5 and then by {0} equals " + result1, num2);
            Console.ReadLine();
        }
    }
}
