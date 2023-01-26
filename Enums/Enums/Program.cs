using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ask user to input current day of the week
                Console.WriteLine("What day of the week is it?");
                string value = Console.ReadLine();

                //Convert string to enum
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);

                //see if the conversion worked
                //does it have to ask system what current day of the week it actually is?
                if (day == DaysOfTheWeek.Thursday) 
                {
                    Console.WriteLine("is the same day");
                    //Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
            

            
            
        }

        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }
}
