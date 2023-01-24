using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiated class to check if method works
            employee.SayName(); 

            IQuittable person = new Employee(); // create object of type iQuittable
            person.Quit();  //calling interface method here
        }
    }
}
