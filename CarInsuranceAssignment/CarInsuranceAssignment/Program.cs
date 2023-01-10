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


            string str1 = "True or False: Have you ever had a DUI?";
            Console.WriteLine(str1);
            bool safe = Convert.ToBoolean(str1);
            // convert to boolean

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticketNum = Convert.ToInt32(ticket);
            // convert to int for value comparison

            //Check qualifications -big if/else statement here?
            //must be > 15
            //no DUI
            //no more than 3 tickets

            // true if old enough, false if not
            bool oldEnough;
            if (ageNum > 15)
            {
                oldEnough = true;
                //Console.WriteLine(oldEnough);
                //Console.ReadLine();  // works? yes
            }
            else
            {
                oldEnough = false;
                //Console.WriteLine(oldEnough);
                //Console.ReadLine(); // works? yes
            }

            // if 3 or fewer tickets, then true. more than 3, false
            bool noSpeed;
            if (ticketNum <= 3)
            {
                noSpeed = true;
                //Console.WriteLine(noSpeed);
                //Console.ReadLine(); // works? yes
            }
            else
            {
                noSpeed = false;
                //Console.WriteLine(noSpeed);
                //Console.ReadLine(); // works? yes
            }

            //if (oldEnough && )





        }
    }
}
