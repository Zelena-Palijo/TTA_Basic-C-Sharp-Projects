using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //tutorial video 1
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        //easier way to add into array
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        
        Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray1[3]); // should both be 200
        Console.ReadLine();
        //end tutorial video 1

        //tutorial video 2
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        Console.WriteLine(numArray2[3]);
        Console.ReadLine();


    }
}
