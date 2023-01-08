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
            string hourlyRate1 = Console.ReadLine();
            int hRate1 = Convert.ToInt32(hourlyRate1);

            //Re-use previous for format
            Console.WriteLine("How many hours do you work per week?");
            string weeklyHour1 = Console.ReadLine();
            int wHour1 = Convert.ToInt32(weeklyHour1);
            //convert to int to do math

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hRate2 = Convert.ToInt32(hourlyRate2);

            //Re-use previous for format
            Console.WriteLine("How many hours do you work per week?");
            string weeklyHour2 = Console.ReadLine();
            int wHour2 = Convert.ToInt32(weeklyHour2);
            //convert to int to do math

            int product = hRate1 * wHour1;
            Console.WriteLine("Annual salary of Person 1: " + product);
            Console.ReadLine();
            //multiple to get weekly rate

            int product2 = hRate2 * wHour2;
            Console.WriteLine("Annual salary of Person 2: " + product2);
            Console.ReadLine();
            //multiple to get weekly rate

            Console.WriteLine("Does Person 1 make more money than Person 2?");

        }
    }
}
