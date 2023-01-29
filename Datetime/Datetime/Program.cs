using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now; //set value for current time
            Console.WriteLine(rightNow); //print current date and time to console
            
            Console.WriteLine("Pick a number."); 
            //later time set, use addhours datetime method
            DateTime laterTime = rightNow.AddHours(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("It will be " + laterTime + " soon enough...");
            Console.ReadLine();

        }
    }
}
