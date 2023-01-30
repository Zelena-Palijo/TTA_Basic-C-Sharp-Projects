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
            const string schoolMotto = "Learn or else";
            Console.WriteLine(schoolMotto);

            Student newStudent = new Student("Zelena");

            Console.WriteLine(newStudent.Id); 
            //Console.ReadLine(); //should automatically output 11111

            var otherStudent = new Student("Christopher");
            //automatically detect type
            Console.WriteLine(otherStudent.Id);
            Console.ReadLine(); //should automatically output 11111

        }
    }
}
