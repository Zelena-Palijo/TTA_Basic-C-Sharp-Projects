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
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Times this has happened: " + i);
                Console.ReadLine(); // if not here, then end program too fast?
                i++; // add 1 each time

            }
            Console.WriteLine("Thank you!");
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine()); // convert age to integer
            bool howOld = age == 29; //true only if equals to 29

            do //had to do switch because wouldn't work without it? 
            {
                switch (age)
                {
                    case 28:
                        Console.WriteLine("Oh you're young");
                        Console.WriteLine("How old are you?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("Oh you're old");
                        Console.WriteLine("How old are you?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Oh wow");
                        Console.WriteLine("How old are you?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29: //true statement
                        Console.WriteLine("Just like me!");
                        howOld = true;
                        break;
                }
            }
            while (!howOld); // if howOld = false or not equal to 29
            Console.Read();
        }
    }
}
