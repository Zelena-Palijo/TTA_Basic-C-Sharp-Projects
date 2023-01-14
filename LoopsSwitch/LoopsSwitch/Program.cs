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
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool howOld = age == 29;

            do
            {
                Console.WriteLine("Cool!");
                Console.ReadLine();
            }
            while (age > 29);
            Console.Read();
        }
    }
}
