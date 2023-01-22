using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Math m1 = new Math(); // instantiate the class

            //Calling method to divide by 2
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Math.Half(num1);

            //Calling method with output
            Console.WriteLine("Pick a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string message = "";
            int result = Math.Add10(num2, out message);

            Console.WriteLine(result + " {0}", message);
            Console.ReadLine();

            // Calling overloaded method
            Math.Multiplyby10(5);
            Math.Multiplyby10(5, 10);
            Console.ReadLine();
            
            
        }
    }
}
