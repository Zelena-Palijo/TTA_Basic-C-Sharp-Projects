using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// PART 1

            //string[] colorArray = { "brown", "black", "white", "cerulean" }; // array of strings
            //List<string> colors = new List<string>(colorArray); //convert to list to add items
            //List<string> colors = new List<string>() { "brown", "black", "white", "cerulean" };
            ////made it a list, but can make it an array also

            //Console.WriteLine("What's your favourite color?"); // prompt to input text
            //string newColor = Console.ReadLine();
            //colors.Add(newColor); // adds user's text input to the end of the string

            //foreach (string color in colors) //loops through and adds the input to end of each string
            //{
            //    Console.WriteLine(color + " " + newColor);
            //}

            ////second loop
            //Console.WriteLine("\n Here are some other people's favorite colors: ");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}
            //Console.ReadLine();


            //// PART 2 
            ////creating infinite loop

            //int count = 0; //add condition to break infinite loop
            //while (true)
            //{
            //    Console.WriteLine("Wake up!"); //infinitely creates loop

            //    if (count++ >= 40) //limiting loop to 40, so once 40 times, then will stop
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("Good-bye.");
            //Console.ReadLine();


            //// PART 3
            //int numCount = 0;
            //while (true) // infinite loop conditions from before
            //{
            //    Console.WriteLine("Keep it moving");

            //    if (numCount++ < 10) // comparison is <
            //    {
            //        break; //stop loop at 10
            //    }

            //}
            //Console.WriteLine("OK, that's good.");
            //Console.ReadLine();

            //int number = 100;
            //while (true) // infinite loop conditions from before
            //{
            //    Console.WriteLine("blah");

            //    if (number-- <= 20) // comparison is <=
            //    {
            //        break; //stop loop at 20
            //    }

            //}
            //Console.WriteLine("OK.");
            //Console.ReadLine();


            // PART 4
            //List<string> coffees = new List<string>() { "latte", "americano", "iced", "regular" };

            //Console.WriteLine("Please choose one of the following: \n " +
            //    "latte, americano, iced, regular");
            //string order = Console.ReadLine();

            //// goes through list to check if order is included
            //for (int i = 0; i < coffees.Count; i++) 
            //{
            //    if (coffees[i] == order)
            //    {
            //        Console.WriteLine("The index of " + order + " is " + i + "."); // write index of item
            //        Console.ReadLine();
            //    }
            //    else if (!coffees.Contains(order)) // if the order is not on the list
            //    {
            //        Console.WriteLine("Sorry, " + order + " is not on the menu. Please choose a menu item.");
            //        Console.ReadLine(); //to print message
            //        break;
            //    }
            //}



            // PART 5
            List<string> chores = new List<string>() { "dishes", "laundry", "vacuum", "dishes", "windows" };
            Console.WriteLine("What chore will you start with today: dishes, laundry, vacuum, windows.");
            string task = Console.ReadLine();

            // goes through the list to see if the things match the task
            for (int i = 0; i < chores.Count; i++)
            {
                if (chores[i] == task)
                {
                    Console.WriteLine("The index of " + task + " is " + i + "."); //write index of matching chore
                    Console.ReadLine();
                }
                // If not on the list, then print error message
                else if (!chores.Contains(task))
                {
                    Console.WriteLine("Sorry, " + task + " is not a chore on the list. \n" +
                        "Please choose a task on the list.");
                    Console.ReadLine();
                    break;
                }
            }
            


            //// PART 6
            //List<string> letters = new List<string>() { "a", "b", "c", "d", "d" };
            //List<string> noDuplicate = new List<string>(); //no duplicates
            //List<string> hasDuplicate = new List<string>(); // has duplicates

            //foreach (string l in letters)
            //{
            //    if (!letters.Contains(l))
            //    { // if the list does NOT contain the letter, add to noDuplicate
            //        noDuplicate.Add(l);
            //    }
            //    else // if the list does contain the letter, then has to hasDuplicate
            //    {
            //        hasDuplicate.Add(l);
            //    }

            //}

            //foreach (string l in noDuplicate) //listing out the ones that are unique
            //{
            //    Console.WriteLine(l + "- is unique");
            //    Console.ReadLine();
            //}

            //foreach (string l in hasDuplicate) //listing out the ones with duplicates
            //{
            //    Console.WriteLine(l + "- is not unique");
            //    Console.ReadLine();
            //}






        }
    }
}
