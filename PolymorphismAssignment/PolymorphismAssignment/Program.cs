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

            Employee person = new Employee(); // polymorphism
            person.Quit();  //calling interface method here
        }
    }
}
