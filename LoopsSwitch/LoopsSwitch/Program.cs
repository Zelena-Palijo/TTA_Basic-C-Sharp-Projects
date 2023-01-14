using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsSwitch
{
    class Program
    {
        static void Main()
        {
            //int i = 0;
            //while (i<10) 
            //{
            //    Console.WriteLine("Times this has happened: "+ i); 
            //    Console.ReadLine(); // if not here, then end program too fast?
            //    i++; // add 1 each time

            //}
            //Console.WriteLine("Thank you!");
            //Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine()); // convert age to integer
            bool howOld = age == 29; //true only if equals to 29

            do
            {
                Console.WriteLine("You are not 29."); // respond if not 29 otherwise end
                Console.ReadLine();
            }
            while (!howOld);

            Console.Read();
            System.Environment.Exit(0);
        }
    }
}
