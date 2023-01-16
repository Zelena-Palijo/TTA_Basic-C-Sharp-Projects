using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Here are some other people's favorite colors:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
            

            
            


        }
    }
}
