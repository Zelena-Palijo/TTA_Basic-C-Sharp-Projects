using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student("Zelena");

            Console.WriteLine(newStudent.Id); 
            Console.ReadLine(); //should automatically output 11111

        }
    }
}
