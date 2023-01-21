using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 18, 36, 54, 72, 90 };
            Console.WriteLine("Pick a number.");
            int choice = Convert.ToInt32(Console.ReadLine());

            foreach (int n in numList)
            {
                int quotient = n / choice;
                Console.WriteLine(n + " divided by " + choice + " equals " + quotient);
            }
            Console.ReadLine();
        }
    }
}
