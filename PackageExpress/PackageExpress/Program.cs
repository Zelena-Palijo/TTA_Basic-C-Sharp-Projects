using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine()); //covert to int to compare
            string result = weight >= 50 ? "Package too big to be shiped via Package Express." : " ";
            //if too large, then prompt. if not too large, move on
            Console.WriteLine(result);
            //Console.ReadLine();

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = width + height + length; // add above
            //Console.WriteLine(totalDimensions);
            //Console.ReadLine();
            string resultTotal = totalDimensions >= 50 ? "Package too big to be shiped via Package Express." : " ";
            Console.WriteLine(resultTotal);
            Console.ReadLine();
        }
    }
}
