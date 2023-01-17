using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1

            //string[] colorArray = { "brown", "black", "white", "cerulean" }; // array of strings
            //List<string> colors = new List<string>(colorArray); //convert to list to add items
            List<string> colors = new List<string>() { "brown", "black", "white", "cerulean" };
            //made it a list, but can make it an array also

            Console.WriteLine("What's your favourite color?"); // prompt to input text
            string newColor = Console.ReadLine();
            colors.Add(newColor); // adds user's text input to the end of the string

            foreach (string color in colors) //loops through and adds the input to end of each string
            {
                Console.WriteLine(color + " " + newColor);
            }

            //second loop
            Console.WriteLine("\n Here are some other people's favorite colors: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();


            // PART 2 
            //creating infinite loop

            int count = 0; //add condition to break infinite loop
            while (true)
            {
                Console.WriteLine("Wake up!"); //infinitely creates loop

                if (count++ >= 40) //limiting loop to 40, so once 40 times, then will stop
                {
                    break;
                }

            }
            Console.WriteLine("Good-bye.");
            Console.ReadLine();


            // PART 3
            int numCount = 0;
            while (true) // infinite loop conditions from before
            {
                Console.WriteLine("Keep it moving");

                if (numCount++ < 10) // comparison is <
                {
                    break; //stop loop at 10
                }

            }
            Console.WriteLine("OK, that's good.");
            Console.ReadLine();

            int number = 100;
            while (true) // infinite loop conditions from before
            {
                Console.WriteLine("blah");

                if (number-- <= 20) // comparison is <=
                {
                    break; //stop loop at 20
                }

            }
            Console.WriteLine("OK.");
            Console.ReadLine();







        }
    }
}
