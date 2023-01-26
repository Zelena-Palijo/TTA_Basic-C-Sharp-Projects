using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number example = new Number(); //create object of struct
            example.Amount = 1.5m; //assign value to value

            Console.WriteLine(example.Amount);
            Console.ReadLine();
            
        }
    }
}
