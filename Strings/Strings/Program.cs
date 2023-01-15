using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string str1 = "Hello, my name is ";
            //Console.WriteLine(str1);
            
            string str2 = "Dr. ";
            //Console.WriteLine(str2);

            string str3 = "Seuss";
            //Console.WriteLine(str3);

            Console.WriteLine(str1 + str2 + str3); //concatenate 3 strings
            string sentence = Console.ReadLine();

            string up1 = str1.ToUpper(); //make str1 all uppercase
            Console.WriteLine(up1); 
            Console.ReadLine();

            StringBuilder sb = new StringBuilder("Please introduce yourself."); //creates StringBuilder
            sb.Append("\n" + str1); //adding one sentence or phrase at a time, add new line for readability
            sb.Append(str2);
            sb.Append(str3);
            Console.WriteLine(sb);
            Console.ReadLine();
            
        }
    }
}
