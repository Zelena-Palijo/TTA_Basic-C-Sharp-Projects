using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instatiate and initilize object with set values
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName(); // call method
            Console.ReadLine(); 
            //output should be "Name: Sample Student"
        }
    }
}
