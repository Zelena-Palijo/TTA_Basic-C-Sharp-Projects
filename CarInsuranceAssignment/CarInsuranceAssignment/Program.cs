using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceAssignment
{
    class Program
    {
        static void Main()
        {
            //Application questions

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            //ask for age, convert to int for value comparison

            Console.WriteLine("True or False: Have you ever had a DUI?");
            Console.ReadLine();
            // needs to be t/f for bool later, so only give t/f as option

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticketNum = Convert.ToInt32(ticket);
            // convert to int for value comparison
        }
    }
}
