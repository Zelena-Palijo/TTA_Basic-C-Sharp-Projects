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

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate = Console.ReadLine();
            int hRate = Convert.ToInt32(hourlyRate);

            //Re-use previous str1 for format
            Console.WriteLine("How many hours do you work per week?");
            string weeklyHour = Console.ReadLine();
            int wHour = Convert.ToInt32(weeklyHour);
            //convert to int to do math

            int product = hRate * wHour;
            Console.WriteLine(product);
            Console.ReadLine();
            //multiple to get weekly rate


        }
    }
}
