using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int age1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                int age1 = Convert.ToInt32(Console.ReadLine());
                if (age1 <= 0) Console.WriteLine("Please enter a positive number.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please try again.");
                Console.ReadLine();
                return;
            }



        }
    }
}
