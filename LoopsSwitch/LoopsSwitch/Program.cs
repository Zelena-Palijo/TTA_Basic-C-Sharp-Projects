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
            while (i<10) 
            {
                Console.WriteLine("Times this has happened: "+ i); 
                Console.ReadLine(); // if not here, then end program too fast?
                i++; // add 1 each time

            }

            Console.WriteLine("how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool howold = age == 29;

            do
            {
                Console.WriteLine("cool!");
                Console.ReadLine();
            }
            while (age > 29);
            Console.Read();
        }
    }
}
