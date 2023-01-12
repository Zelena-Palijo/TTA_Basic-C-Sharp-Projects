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
            int ageNum = Convert.ToInt32(Console.ReadLine());
            //ask for age, convert to int for value comparison

            string str1 = "True or False: Have you ever had a DUI?";
            Console.WriteLine(str1);
            bool safe = Convert.ToBoolean(Console.ReadLine());
            // convert to boolean to use later

            Console.WriteLine("How many speeding tickets do you have?");
            int ticketNum = Convert.ToInt32(Console.ReadLine());
            // convert to int for value comparison

            //Check qualifications -big if/else statement here?
          

            // true if old enough, false if not
            bool oldEnough = false;
            if (ageNum > 15)
            {
                oldEnough = true;
                //Console.WriteLine(oldEnough);
                //Console.ReadLine();  // works? yes
            }
            

            //convert DUI, switch true DUI = false
            bool notSafe = true;
            if (safe == false)
            {
                notSafe = true;
            }
           
        

            // if 3 or fewer tickets, then true. more than 3, false
            bool noSpeed = true;
            if (ticketNum <= 3)
            {
                noSpeed = true;
                //Console.WriteLine(noSpeed);
                //Console.ReadLine(); // works? yes
            }
            

            if (oldEnough && notSafe && noSpeed)
            {
                //if all true then print yes
                Console.WriteLine("You meet all the requirements.");
                Console.ReadLine();
            }

            else
            {
                //if 1 is false then will print no
                Console.WriteLine("You do not meet all the requirements.");
                Console.ReadLine();
            }






        }
    }
}
