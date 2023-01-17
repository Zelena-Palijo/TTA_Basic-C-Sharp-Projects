using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
            //Create one-dimensional array of strings
            string[] shoppingList = new string[] { "eggs", "pasta", "bacon", "pepper", "parm" };
            Console.WriteLine("Please select a number between 0 to 4 to see an item from the list.");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice > 4)
            {
                Console.WriteLine("Sorry, your request cannot be completed. \n " +
                   "Please choose a number between 0 to 4.");
                choice = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(shoppingList[choice]);
            Console.ReadLine();

            //if (choice <= 4) //wanted to use while loop or do while loop but wouldn't work?
            //{
            //    Console.WriteLine(shoppingList[choice]);
            //    Console.ReadLine();

            //}
            //else // default if chooses something other than 0-4
            //{
            //    Console.WriteLine("Sorry, your request cannot be completed. \n " +
            //    "Please choose a number between 0 to 4.");
            //    Console.ReadLine();
            //}



            //Create one-dimensional array of integers, copy and paste a lot from above
            int[] numArray = new int[] { 45, 69, 77, 32, 1 };
            Console.WriteLine("Please select a number between 0 to 4 to see an item from the list.");
            int numChoice = Convert.ToInt32(Console.ReadLine());

            while (numChoice > 4)
            {
                Console.WriteLine("Sorry, your request cannot be completed. \n " +
                   "Please choose a number between 0 to 4.");
                numChoice = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(numArray[numChoice]);
            Console.ReadLine();

            //if (numChoice <= 4)
            //{
            //    Console.WriteLine(numArray[numChoice]);
            //    Console.ReadLine();

            //}
            //else // default if chooses something other than 0-4
            //{
            //    Console.WriteLine("Sorry, your request cannot be completed. \n " +
            //    "Please choose a number between 0 to 4.");
            //    Console.ReadLine();
            //}


            // list of strings
            List<string> stringList = new List<string> { "water", "earth", "fire", "air" };
            Console.WriteLine("Please select a number between 0 to 3 to choose your element.");
            int element = Convert.ToInt32(Console.ReadLine());

            while (element > 3)
            {
                Console.WriteLine("Sorry, your request cannot be completed. \n " +
                "Please choose a number between 0 to 3.");
                element = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(stringList[element]);
            Console.ReadLine();

            //if (element <= 3)
            //{
            //    Console.WriteLine("Your element is:" + stringList[element]);
            //    Console.ReadLine();

            //}
            //else // default if chooses something other than 0-3
            //{
            //    Console.WriteLine("Sorry, your request cannot be completed. \n " +
            //    "Please choose a number between 0 to 3.");
            //    Console.ReadLine();
            //}

    }
}

