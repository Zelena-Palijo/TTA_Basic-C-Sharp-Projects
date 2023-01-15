using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
        string[] shoppingList = new string[] { "eggs", "pasta", "bacon", "pepper", "parm" };
        Console.WriteLine("Please select a number between 0 to 4 to see an item from the list.");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        if(choice <= 4)
        {
            Console.WriteLine(shoppingList[choice]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Sorry, your request cannot be completed. \n " +
                "Please choose a number between 0 to 4.");
            Console.ReadLine();
        }

        
        }
    }

