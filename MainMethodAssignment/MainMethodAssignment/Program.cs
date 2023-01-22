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
            Console.WriteLine("Please choose a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //calling methods here, inputting num1
            int result1 = Math.MultiplyBy5(num1);

            Console.WriteLine(num1 + " multiplied by 5 is " + result1);
            Console.ReadLine();
        }
    }
}
