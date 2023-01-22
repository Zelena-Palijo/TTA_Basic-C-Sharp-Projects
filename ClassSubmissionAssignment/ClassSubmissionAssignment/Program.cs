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

            // Calling overloaded method 1
            Console.WriteLine("Pick a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result3 = Math.Multiplyby10(num3);
            Console.WriteLine(result3);
            Console.ReadLine();

            int num4 = 10;
            int result4 = Math.Multiplyby10(num3, num4);
            Console.WriteLine(result4);
            Console.ReadLine();
            
            
        }
    }
}
