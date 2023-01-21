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
            try
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
            //if person chooses 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please choose a non-zero number.");
                return;
            }
            // if person inputs string
            catch (FormatException ex)
            {
                Console.WriteLine("Please choose a whole number.");
                return;
            }
            //for general issues
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                // message that they emerged from try/catch block
                Console.WriteLine("The program will now end."); 
                Console.ReadLine();
            }

            
        }
    }
}
