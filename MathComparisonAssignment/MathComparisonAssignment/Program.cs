using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonAssignment
{
    class Program
    {
        static void Main()
        {
            //string str1 = "Anonymous Income Comparison Program";
            //Console.WriteLine(str1);

            Console.WriteLine("Anonymous Income Comparison Program");
            //Console.ReadLine();
            //Program must start with this statement

            Console.WriteLine("Person 1");

            string str1 = "What is your hourly rate?";
            Console.WriteLine(str1);
            string hourlyRate = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourlyRate);




        }
    }
}
