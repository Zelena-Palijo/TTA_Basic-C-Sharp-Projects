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

            Math math = new Math(); //instantiate the class

            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //call method normal way
            math.Sum(num1, num2); // call the method, but void 

            //call method second way with named method
            math.Sum(num1: 13, num2: 14);


            //cannot run due to void method?
        }
    }
}
